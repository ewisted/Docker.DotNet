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
    public class IPAMConfig // (network.IPAMConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Subnet")]
#else
        [DataMember(Name = "Subnet", EmitDefaultValue = false)]
#endif
        public string Subnet { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPRange")]
#else
        [DataMember(Name = "IPRange", EmitDefaultValue = false)]
#endif
        public string IPRange { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Gateway")]
#else
        [DataMember(Name = "Gateway", EmitDefaultValue = false)]
#endif
        public string Gateway { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AuxiliaryAddresses")]
#else
        [DataMember(Name = "AuxiliaryAddresses", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> AuxAddress { get; set; }
    }
}
