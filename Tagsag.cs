﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Clubtag_winform_CRUD;
//
//    var tagsag = Tagsag.FromJson(jsonString);

namespace Clubtag_winform_CRUD
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Tagsag
    {
        [JsonProperty("id")]
        public long TagsagId { get; set; }

        [JsonProperty("entry", NullValueHandling = NullValueHandling.Ignore)]
        public string TagsagEntry { get; set; }

        [JsonProperty("rating", NullValueHandling = NullValueHandling.Ignore)]
        public long? TagsagRating { get; set; }

        [JsonProperty("fullname", NullValueHandling = NullValueHandling.Ignore)]
        public string TagsagFullname { get; set; }

        [JsonProperty("interest", NullValueHandling = NullValueHandling.Ignore)]
        public string TagsagInterest { get; set; }

        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("Entry", NullValueHandling = NullValueHandling.Ignore)]
        public string Entry { get; set; }

        [JsonProperty("Rating", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rating { get; set; }

        [JsonProperty("Fullname", NullValueHandling = NullValueHandling.Ignore)]
        public string Fullname { get; set; }

        [JsonProperty("Interest", NullValueHandling = NullValueHandling.Ignore)]
        public string Interest { get; set; }

        [JsonProperty("kiiratas", NullValueHandling = NullValueHandling.Ignore)]
        public string TagsagKiiratas { get; set; }

        [JsonProperty("Kiiratas", NullValueHandling = NullValueHandling.Ignore)]
        public string Kiiratas { get; set; }

        public override string ToString()
        {
            return TagsagFullname;
        }
    }

    public partial class Tagsag
    {
        public static Tagsag[] FromJson(string json) => JsonConvert.DeserializeObject<Tagsag[]>(json, Clubtag_winform_CRUD.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Tagsag[] self) => JsonConvert.SerializeObject(self, Clubtag_winform_CRUD.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
