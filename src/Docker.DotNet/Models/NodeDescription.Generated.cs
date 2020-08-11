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
    public class NodeDescription // (swarm.NodeDescription)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Hostname")]
#else
        [DataMember(Name = "Hostname", EmitDefaultValue = false)]
#endif
        public string Hostname { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Platform")]
#else
        [DataMember(Name = "Platform", EmitDefaultValue = false)]
#endif
        public Platform Platform { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Resources")]
#else
        [DataMember(Name = "Resources", EmitDefaultValue = false)]
#endif
        public SwarmResources Resources { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Engine")]
#else
        [DataMember(Name = "Engine", EmitDefaultValue = false)]
#endif
        public EngineDescription Engine { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("TLSInfo")]
#else
        [DataMember(Name = "TLSInfo", EmitDefaultValue = false)]
#endif
        public TLSInfo TLSInfo { get; set; }
    }
}
