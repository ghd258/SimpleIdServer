﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SimpleIdServer.IdServer.Domains;
using SimpleIdServer.IdServer.Domains.DTOs;
using SimpleIdServer.IdServer.Exceptions;
using SimpleIdServer.IdServer.Jwt;
using SimpleIdServer.IdServer.Store;
using System;
using System.Linq;
using System.Net;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.Api.UMAResources
{
    public class UMAResourcesController : BaseController
    {
        public const string UserAccessPolicyUri = "user_access_policy_uri";
        private readonly IUmaResourceRepository _umaResourceRepository;
        private readonly IJwtBuilder _jwtBuilder;
        private readonly ILogger<UMAResourcesController> _logger;

        public UMAResourcesController(IUmaResourceRepository umaResourceRepository, IJwtBuilder jwtBuilder, ILogger<UMAResourcesController> logger)
        {
            _umaResourceRepository = umaResourceRepository;
            _jwtBuilder = jwtBuilder;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            try
            {
                CheckHasPAT(_jwtBuilder);
                var result = await _umaResourceRepository.Query().AsNoTracking().ToListAsync(cancellationToken);
                return new OkObjectResult(result.Select(r => r.Id));
            }
            catch(OAuthException ex)
            {
                _logger.LogError(ex.ToString());
                return BuildError(HttpStatusCode.BadRequest, ex.Code, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOne(string id, CancellationToken cancellationToken)
        {
            try
            {
                CheckHasPAT(_jwtBuilder);
                var result = await _umaResourceRepository.Query().Include(r => r.Translations).AsNoTracking().SingleOrDefaultAsync(r => r.Id == id, cancellationToken);
                if (result == null) return BuildError(System.Net.HttpStatusCode.NotFound, ErrorCodes.NOT_FOUND, ErrorMessages.UNKNOWN_UMA_RESOURCE);
                return new OkObjectResult(result);
            }
            catch (OAuthException ex)
            {
                _logger.LogError(ex.ToString());
                return BuildError(HttpStatusCode.BadRequest, ex.Code, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UMAResourceRequest request, CancellationToken cancellationToken)
        {
            try
            {
                CheckHasPAT(_jwtBuilder);
                Validate(request);
                if(string.IsNullOrWhiteSpace(request.Subject))
                    throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, UMAResourceNames.Subject));
                var umaResource = new UMAResource(Guid.NewGuid().ToString(), DateTime.UtcNow)
                {
                    IconUri = request.IconUri,
                    Scopes = request.Scopes,
                    Type = request.Type
                };
                umaResource.UpdateTranslations(request.Translations.Select(t => new Translation { Key = t.Name, Language = t.Language, Value = t.Value }));
                _umaResourceRepository.Add(umaResource);
                await _umaResourceRepository.SaveChanges(cancellationToken);
                _logger.LogInformation("UMA resource {UmaResourceId} has been added", umaResource.Id);
                var result = new JsonObject
                {
                    [UMAResourceNames.Id] = umaResource.Id,
                    [UserAccessPolicyUri] = Url.Action("Edit", "Resources", new { id = umaResource.Id })
                };
                return new ContentResult
                {
                    Content = result.ToJsonString(),
                    StatusCode = (int)HttpStatusCode.Created,
                    ContentType = "application/json"
                };
            }
            catch(OAuthException ex)
            {
                _logger.LogError(ex.ToString());
                return BuildError(HttpStatusCode.BadRequest, ex.Code, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(string id, [FromBody] UMAResourceRequest request, CancellationToken cancellationToken)
        {
            try
            {
                CheckHasPAT(_jwtBuilder);
                Validate(request);
                var currentUmaResource = await _umaResourceRepository.Query().SingleOrDefaultAsync(r => r.Id == id, cancellationToken);
                if (currentUmaResource == null)
                    return BuildError(HttpStatusCode.NotFound, ErrorCodes.NOT_FOUND, ErrorMessages.UNKNOWN_UMA_RESOURCE);

                currentUmaResource.IconUri = request.IconUri;
                currentUmaResource.Scopes = request.Scopes;
                currentUmaResource.Type = request.Type;
                currentUmaResource.UpdateDateTime = DateTime.UtcNow;
                currentUmaResource.UpdateTranslations(request.Translations.Select(t => new Translation { Key = t.Name, Language = t.Language, Value = t.Value }));
                await _umaResourceRepository.SaveChanges(cancellationToken);
                _logger.LogInformation("UMA resource {UmaResourceId} has been updated", currentUmaResource.Id);
                var result = new JsonObject
                {
                    [UMAResourceNames.Id] = currentUmaResource.Id
                };
                return new ContentResult
                {
                    ContentType = "application/json",
                    Content = result.ToJsonString(),
                    StatusCode = (int)HttpStatusCode.OK
                };
            }
            catch (OAuthException ex)
            {
                _logger.LogError(ex.ToString());
                return BuildError(HttpStatusCode.BadRequest, ex.Code, ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id, CancellationToken cancellationToken)
        {
            try
            {
                CheckHasPAT(_jwtBuilder);
                var currentUmaResource = await _umaResourceRepository.Query().SingleOrDefaultAsync(r => r.Id == id, cancellationToken);
                if (currentUmaResource == null)
                    return BuildError(HttpStatusCode.NotFound, ErrorCodes.NOT_FOUND, ErrorMessages.UNKNOWN_UMA_RESOURCE);

                _umaResourceRepository.Delete(currentUmaResource);
                await _umaResourceRepository.SaveChanges(cancellationToken);
                return new NoContentResult();
            }
            catch (OAuthException ex)
            {
                _logger.LogError(ex.ToString());
                return BuildError(HttpStatusCode.BadRequest, ex.Code, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> AddPermissions(string id, [FromBody] UMAResourcePermissionsRequest request, CancellationToken cancellationToken)
        {
            try
            {
                CheckHasPAT(_jwtBuilder);
                var currentUmaResource = await _umaResourceRepository.Query().Include(r => r.Permissions).ThenInclude(p => p.Claims).SingleOrDefaultAsync(r => r.Id == id, cancellationToken);
                if (currentUmaResource == null)
                    return BuildError(HttpStatusCode.NotFound, ErrorCodes.NOT_FOUND, ErrorMessages.UNKNOWN_UMA_RESOURCE);
                Validate(request);
                var permissions = request.Permissions.Select(p =>
                {
                    return new UMAResourcePermission(Guid.NewGuid().ToString(), DateTime.UtcNow)
                    {
                        Scopes = p.Scopes.ToList(),
                        Claims = p.Claims.Select(c => new UMAResourcePermissionClaim
                        {
                            ClaimType = c.ClaimType,
                            FriendlyName = c.ClaimFriendlyName,
                            Name = c.ClaimName,
                            Value = c.ClaimValue
                        }).ToList()
                    };
                });
                currentUmaResource.Permissions = permissions.ToList();
                currentUmaResource.UpdateDateTime = DateTime.UtcNow;
                await _umaResourceRepository.SaveChanges(cancellationToken);
                var result = new JsonObject
                {
                    [UMAResourceNames.Id] = currentUmaResource.Id
                };
                return new ContentResult
                {
                    ContentType = "application/json",
                    Content = result.ToString(),
                    StatusCode = (int)HttpStatusCode.OK
                };
            }
            catch (OAuthException ex)
            {
                _logger.LogError(ex.ToString());
                return BuildError(HttpStatusCode.BadRequest, ex.Code, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPermissions(string id, CancellationToken cancellationToken)
        {
            try
            {
                CheckHasPAT(_jwtBuilder);
                var currentUmaResource = await _umaResourceRepository.Query().Include(r => r.Permissions).ThenInclude(p => p.Claims).AsNoTracking().SingleOrDefaultAsync(r => r.Id == id, cancellationToken);
                if (currentUmaResource == null)
                    return BuildError(HttpStatusCode.NotFound, ErrorCodes.NOT_FOUND, ErrorMessages.UNKNOWN_UMA_RESOURCE);
                return new OkObjectResult(currentUmaResource.Permissions);
            }
            catch (OAuthException ex)
            {
                _logger.LogError(ex.ToString());
                return BuildError(HttpStatusCode.BadRequest, ex.Code, ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePermissions(string id, CancellationToken cancellationToken)
        {
            try
            {
                CheckHasPAT(_jwtBuilder);
                var currentUmaResource = await _umaResourceRepository.Query().Include(r => r.Permissions).ThenInclude(p => p.Claims).SingleOrDefaultAsync(r => r.Id == id, cancellationToken);
                if (currentUmaResource == null)
                    return BuildError(HttpStatusCode.NotFound, ErrorCodes.NOT_FOUND, ErrorMessages.UNKNOWN_UMA_RESOURCE);
                currentUmaResource.Permissions.Clear();
                await _umaResourceRepository.SaveChanges(cancellationToken);
                return new NoContentResult();
            }
            catch (OAuthException ex)
            {
                _logger.LogError(ex.ToString());
                return BuildError(HttpStatusCode.BadRequest, ex.Code, ex.Message);
            }
        }

        private void Validate(UMAResourceRequest request)
        {
            if (request.Scopes == null || !request.Scopes.Any())
                throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, UMAResourceNames.ResourceScopes));
        }

        private void Validate(UMAResourcePermissionsRequest request)
        {
            if(request.Permissions == null || !request.Permissions.Any())
                throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, UMAResourcePermissionNames.Permissions));

            foreach(var permission in request.Permissions)
            {
                if(permission.Claims == null || !permission.Claims.Any())
                    throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, $"{UMAResourcePermissionNames.Permissions}.{UMAResourcePermissionNames.Claims}"));

                if(permission.Scopes == null || !permission.Scopes.Any())
                    throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, $"{UMAResourcePermissionNames.Permissions}.{UMAResourcePermissionNames.Scopes}"));

                foreach(var claim in permission.Claims)
                {
                    if(string.IsNullOrWhiteSpace(claim.ClaimName))
                        throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, $"{UMAResourcePermissionNames.Permissions}.{UMAResourcePermissionNames.Claims}.{UMAResourcePermissionNames.ClaimName}"));

                    if (string.IsNullOrWhiteSpace(claim.ClaimValue))
                        throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, $"{UMAResourcePermissionNames.Permissions}.{UMAResourcePermissionNames.Claims}.{UMAResourcePermissionNames.ClaimValue}"));
                }
            }
        }
    }
}
