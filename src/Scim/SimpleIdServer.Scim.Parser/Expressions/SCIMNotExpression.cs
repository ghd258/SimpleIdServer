﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Scim.Domains;
using System.Collections.Generic;

namespace SimpleIdServer.Scim.Parser.Expressions
{
    public class SCIMNotExpression : SCIMExpression
    {
        public SCIMNotExpression(SCIMExpression content)
        {
            Content = content;
        }

        public SCIMExpression Content { get; private set; }

        public override object Clone()
        {
            return new SCIMNotExpression((SCIMExpression)Content.Clone());
        }

        public override ICollection<SCIMRepresentationAttribute> BuildEmptyAttributes() => new List<SCIMRepresentationAttribute>();
    }
}
