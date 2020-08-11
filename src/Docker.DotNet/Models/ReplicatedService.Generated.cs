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
    public class ReplicatedService // (swarm.ReplicatedService)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Replicas")]
#else
        [DataMember(Name = "Replicas", EmitDefaultValue = false)]
#endif
        public ulong? Replicas { get; set; }
    }
}
