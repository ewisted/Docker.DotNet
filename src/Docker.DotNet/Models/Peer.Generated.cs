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
    public class Peer // (swarm.Peer)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("NodeID")]
#else
        [DataMember(Name = "NodeID", EmitDefaultValue = false)]
#endif
        public string NodeID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Addr")]
#else
        [DataMember(Name = "Addr", EmitDefaultValue = false)]
#endif
        public string Addr { get; set; }
    }
}
