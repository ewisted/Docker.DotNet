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
    public class EndpointIPAMConfig // (network.EndpointIPAMConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("IPv4Address")]
#else
        [DataMember(Name = "IPv4Address", EmitDefaultValue = false)]
#endif
        public string IPv4Address { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPv6Address")]
#else
        [DataMember(Name = "IPv6Address", EmitDefaultValue = false)]
#endif
        public string IPv6Address { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LinkLocalIPs")]
#else
        [DataMember(Name = "LinkLocalIPs", EmitDefaultValue = false)]
#endif
        public IList<string> LinkLocalIPs { get; set; }
    }
}
