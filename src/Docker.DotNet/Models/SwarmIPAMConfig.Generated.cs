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
    public class SwarmIPAMConfig // (swarm.IPAMConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Subnet")]
#else
        [DataMember(Name = "Subnet", EmitDefaultValue = false)]
#endif
        public string Subnet { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Range")]
#else
        [DataMember(Name = "Range", EmitDefaultValue = false)]
#endif
        public string Range { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Gateway")]
#else
        [DataMember(Name = "Gateway", EmitDefaultValue = false)]
#endif
        public string Gateway { get; set; }
    }
}
