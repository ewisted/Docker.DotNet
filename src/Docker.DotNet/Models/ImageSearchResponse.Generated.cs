#if !NETSTANDARD2_1
using System.Runtime.Serialization;
#else
using System.Text.Json.Serialization;
#endif

namespace Docker.DotNet.Models
{
#if !NETSTANDARD2_1
    [DataContract]
#endif
    public class ImageSearchResponse // (registry.SearchResult)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("star_count")]
#else
        [DataMember(Name = "star_count", EmitDefaultValue = false)]
#endif
        public long StarCount { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("is_official")]
#else
        [DataMember(Name = "is_official", EmitDefaultValue = false)]
#endif
        public bool IsOfficial { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("name")]
#else
        [DataMember(Name = "name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("is_automated")]
#else
        [DataMember(Name = "is_automated", EmitDefaultValue = false)]
#endif
        public bool IsAutomated { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("description")]
#else
        [DataMember(Name = "description", EmitDefaultValue = false)]
#endif
        public string Description { get; set; }
    }
}
