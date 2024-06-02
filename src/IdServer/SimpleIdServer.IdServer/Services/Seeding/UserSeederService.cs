﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license informa
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SimpleIdServer.IdServer.Builders;
using SimpleIdServer.IdServer.Domains;
using SimpleIdServer.IdServer.DTOs.Seeds;
using SimpleIdServer.IdServer.Services.Seeding.Interfaces;
using SimpleIdServer.IdServer.Store;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.Services.Seeding
{
    /// <summary>
    /// Implements the method that allows to seed records of users.
    /// </summary>
    internal class UserSeederService : ISeederService<UserSeedDto>
    {
        private readonly ILogger<UserSeederService> _logger;
        private readonly StoreDbContext _storeDbContext;

        public UserSeederService(ILogger<UserSeederService> logger, StoreDbContext storeDbContext)
        {
            _logger = logger;
            _storeDbContext = storeDbContext;
        }

        public async Task SeedAsync(IReadOnlyCollection<UserSeedDto> records, CancellationToken cancellationToken = default)
        {
            string[] dbLoginNames = await _storeDbContext.Users.Select(u => u.Name.ToUpper()).ToArrayAsync(cancellationToken);
            UserSeedDto[] usersNotInDb = (from r in records
                                          join ln in dbLoginNames on r.Login.ToUpper() equals ln
                                          into qry
                                          from l_join in qry.DefaultIfEmpty()
                                          where l_join == null
                                          select r).ToArray();

            if (usersNotInDb.Length > 0)
            {
                var usersToCreate = new List<User>();

                foreach (var user in usersNotInDb)
                {
                    var builder = UserBuilder.Create(user.Login, user.Password, user.FirstName)
                        .SetLastname(user.LastName)
                        .SetEmail(user.Email);

                    foreach (var role in user.Roles) { builder.AddRole(role); }

                    usersToCreate.Add(builder.Build());
                }

                await _storeDbContext.Users.AddRangeAsync(usersToCreate, cancellationToken);
                await _storeDbContext.SaveChangesAsync(cancellationToken);
            }

            _logger.LogInformation("{count} users seeded.", usersNotInDb.Length);
        }
    }
}
