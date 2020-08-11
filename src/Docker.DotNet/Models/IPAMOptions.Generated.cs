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
    public class IPAMOptions // (swarm.IPAMOptions)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Driver")]
#else
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
#endif
        public SwarmDriver Driver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Configs")]
#else
        [DataMember(Name = "Configs", EmitDefaultValue = false)]
#endif
        public IList<SwarmIPAMConfig> Configs { get; set; }
    }
}
