﻿namespace Nancy.ViewEngines.Razor
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class TextResourceFinder : DynamicObject
    {
        private readonly ITextResource textResource;
        private readonly NancyContext context;

        public TextResourceFinder(ITextResource textResource, NancyContext context)
        {
            this.textResource = textResource;
            this.context = context;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = this.textResource[binder.Name, this.context];
            return true;
        }
    }
}
