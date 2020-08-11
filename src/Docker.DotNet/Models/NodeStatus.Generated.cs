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
    public class NodeStatus // (swarm.NodeStatus)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("State")]
#else
        [DataMember(Name = "State", EmitDefaultValue = false)]
#endif
        public string State { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Message")]
#else
        [DataMember(Name = "Message", EmitDefaultValue = false)]
#endif
        public string Message { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Addr")]
#else
        [DataMember(Name = "Addr", EmitDefaultValue = false)]
#endif
        public string Addr { get; set; }
    }
}
