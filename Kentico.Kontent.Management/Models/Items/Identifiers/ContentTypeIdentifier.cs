﻿using Newtonsoft.Json;
using System;

namespace Kentico.Kontent.Management.Models.Items
{
    /// <summary>
    /// Represents identifier of the content type.
    /// </summary>
    public sealed class ContentTypeIdentifier
    {
        /// <summary>
        /// Gets id of the identifier.
        /// </summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Guid? Id { get; private set; }

        /// <summary>
        /// Gets codename of the identifier.
        /// </summary>
        [JsonProperty("codename", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Codename { get; private set; }

        /// <summary>
        /// Gets external id of the identifier.
        /// </summary>
        [JsonProperty("external_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// Creates identifier by id.
        /// </summary>
        /// <param name="id">The id of the identifier.</param>
        public static ContentTypeIdentifier ById(Guid id)
        {
            return new ContentTypeIdentifier() { Id = id };
        }

        /// <summary>
        /// Creates identifier by codename.
        /// </summary>
        /// <param name="codename">The codename of the identifier.</param>
        public static ContentTypeIdentifier ByCodename(string codename)
        {
            return new ContentTypeIdentifier() { Codename = codename };
        }

        /// <summary>
        /// Creates identifier by external id.
        /// </summary>
        /// <param name="externalId">The external id of the identifier.</param>
        public static ContentTypeIdentifier ByExternalId(string externalId)
        {
            return new ContentTypeIdentifier() { ExternalId = externalId };
        }
    }
}
