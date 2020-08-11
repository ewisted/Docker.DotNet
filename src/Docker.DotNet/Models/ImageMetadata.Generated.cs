using System;
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
    public class ImageMetadata // (types.ImageMetadata)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("LastTagTime")]
#else
        [DataMember(Name = "LastTagTime", EmitDefaultValue = false)]
#endif
        public DateTime LastTagTime { get; set; }
    }
}
