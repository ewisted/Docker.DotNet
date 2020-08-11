using System.Collections.Generic;
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
    public class VolumeOptions // (mount.VolumeOptions)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("NoCopy")]
#else
        [DataMember(Name = "NoCopy", EmitDefaultValue = false)]
#endif
        public bool NoCopy { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DriverConfig")]
#else
        [DataMember(Name = "DriverConfig", EmitDefaultValue = false)]
#endif
        public Driver DriverConfig { get; set; }
    }
}
