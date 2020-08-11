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
    public class ManagerStatus // (swarm.ManagerStatus)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Leader")]
#else
        [DataMember(Name = "Leader", EmitDefaultValue = false)]
#endif
        public bool Leader { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Reachability")]
#else
        [DataMember(Name = "Reachability", EmitDefaultValue = false)]
#endif
        public string Reachability { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Addr")]
#else
        [DataMember(Name = "Addr", EmitDefaultValue = false)]
#endif
        public string Addr { get; set; }
    }
}
