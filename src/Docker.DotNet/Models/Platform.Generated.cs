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
    public class Platform // (swarm.Platform)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Architecture")]
#else
        [DataMember(Name = "Architecture", EmitDefaultValue = false)]
#endif
        public string Architecture { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OS")]
#else
        [DataMember(Name = "OS", EmitDefaultValue = false)]
#endif
        public string OS { get; set; }
    }
}
