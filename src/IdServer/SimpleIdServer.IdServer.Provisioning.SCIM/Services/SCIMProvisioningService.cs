﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using BlushingPenguin.JsonPath;
using SimpleIdServer.IdServer.Domains;
using SimpleIdServer.IdServer.Jobs;
using SimpleIdServer.IdServer.Provisioning.SCIM.Jobs;
using SimpleIdServer.IdServer.Store;
using SimpleIdServer.Scim.Client;
using SimpleIdServer.Scim.Client.DTOs;
using System.Text.Json;

namespace SimpleIdServer.IdServer.Provisioning.SCIM.Services;

public class SCIMProvisioningService : IProvisioningService
{
    private readonly IExtractedRepresentationRepository _extractedRepresentationRepository;

    public SCIMProvisioningService(IExtractedRepresentationRepository extractedRepresentationRepository)
    {
        _extractedRepresentationRepository = extractedRepresentationRepository;
    }

    public string Name => SCIMRepresentationsExtractionJob.NAME;

    public async IAsyncEnumerable<ExtractedResult> Extract(object obj, IdentityProvisioningDefinition definition)
    {
        var options = obj as SCIMRepresentationsExtractionJobOptions;
        using (var scimClient = new SCIMClient(options.SCIMEdp))
        {
            var accessToken = await GetAccessToken(options);
            var searchUsers = await scimClient.SearchUsers(new SearchRequest
            {
                Count = options.Count,
                StartIndex = 1
            }, accessToken, CancellationToken.None);
            var filterUsers = await FilterUsers(searchUsers.Item1);
            var result = ExtractUsers(filterUsers, 1, definition);
            yield return result;
            var totalResults = searchUsers.Item1.TotalResults;
            var count = searchUsers.Item1.ItemsPerPage;
            var nbPages = ((int)Math.Ceiling((double)totalResults / count));
            var allPages = Enumerable.Range(2, nbPages - 1);
            foreach (var currentPage in allPages)
            {
                var newSearchUsers = await scimClient.SearchUsers(new SearchRequest
                {
                    Count = count,
                    StartIndex = currentPage * count
                }, accessToken, CancellationToken.None);
                var newFilterUsers = FilterUsers(newSearchUsers.Item1).Result;
                result = ExtractUsers(newFilterUsers, 1, definition);
                yield return result;
            }
        }
    }

    private ExtractedResult ExtractUsers(IEnumerable<RepresentationResult> resources, int currentPage, IdentityProvisioningDefinition definition)
    {
        var result = new ExtractedResult();
        foreach (var resource in resources) result.Users.Add(ExtractUser(resource, definition));
        result.CurrentPage = currentPage;
        return result;
    }

    private ExtractedUserResult ExtractUser(RepresentationResult resource, IdentityProvisioningDefinition definition)
    {
        var jsonDoc = JsonDocument.Parse(resource.AdditionalData.ToJsonString());
        var values = new List<string>();
        foreach (var mappingRule in definition.MappingRules)
        {
            var token = jsonDoc.SelectToken(mappingRule.From);
            if (token == null)
            {
                values.Add(string.Empty);
                continue;
            }

            values.Add(token.Value.GetString());
        }

        return new ExtractedUserResult
        {
            Id = resource.Id,
            Version = resource.Meta.Version.ToString(),
            Values = values
        };
    }

    private async Task<IEnumerable<RepresentationResult>> FilterUsers(SearchResult<RepresentationResult> searchResult)
    {
        var ids = searchResult.Resources.Select(r => r.Id);
        var extractedRepresentations = await _extractedRepresentationRepository.BulkRead(ids);
        return searchResult.Resources.Where((r) =>
        {
            var er = extractedRepresentations.SingleOrDefault(er => er.ExternalId == r.Id);
            return er == null || er.Version != r.Meta.Version.ToString();
        }).ToList();
    }

    private Task<string> GetAccessToken(SCIMRepresentationsExtractionJobOptions options)
    {
        switch (options.AuthenticationType)
        {
            case ClientAuthenticationTypes.APIKEY:
                return Task.FromResult(options.ApiKey);
            default:
                throw new NotImplementedException($"Authentication {options.AuthenticationType} is not supported");
        }
    }
}
