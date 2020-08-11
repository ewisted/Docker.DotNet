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
    public class Endpoint // (swarm.Endpoint)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Spec")]
#else
        [DataMember(Name = "Spec", EmitDefaultValue = false)]
#endif
        public EndpointSpec Spec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Ports")]
#else
        [DataMember(Name = "Ports", EmitDefaultValue = false)]
#endif
        public IList<PortConfig> Ports { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("VirtualIPs")]
#else
        [DataMember(Name = "VirtualIPs", EmitDefaultValue = false)]
#endif
        public IList<EndpointVirtualIP> VirtualIPs { get; set; }
    }
}
