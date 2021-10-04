﻿using System;

namespace Kentico.Kontent.Management.Modules.UrlBuilder.Templates
{
    internal class CollectionTemplate : UrlTemplate
    {
        public override string Url => "/collections";

        public override string UrlId => "/collections/{0}";

        public override string UrlCodename => "/collections/codename/{0}";

        public override string UrlExternalId => throw new NotImplementedException("collections do not have external id url");
    }
}
