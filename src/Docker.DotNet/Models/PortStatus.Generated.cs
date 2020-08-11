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
    public class PortStatus // (swarm.PortStatus)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Ports")]
#else
        [DataMember(Name = "Ports", EmitDefaultValue = false)]
#endif
        public IList<PortConfig> Ports { get; set; }
    }
}
