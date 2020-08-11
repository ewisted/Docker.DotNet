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
    public class EndpointSpec // (swarm.EndpointSpec)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Mode")]
#else
        [DataMember(Name = "Mode", EmitDefaultValue = false)]
#endif
        public string Mode { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Ports")]
#else
        [DataMember(Name = "Ports", EmitDefaultValue = false)]
#endif
        public IList<PortConfig> Ports { get; set; }
    }
}
