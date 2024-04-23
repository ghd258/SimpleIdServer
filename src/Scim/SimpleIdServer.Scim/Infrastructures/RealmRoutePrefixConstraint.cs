﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace SimpleIdServer.Scim.Infrastructures;

public class RealmRoutePrefixConstraint : IRouteConstraint
{
    public bool Match(HttpContext? httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection) => true;
}
