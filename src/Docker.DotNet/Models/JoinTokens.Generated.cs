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
    public class JoinTokens // (swarm.JoinTokens)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Worker")]
#else
        [DataMember(Name = "Worker", EmitDefaultValue = false)]
#endif
        public string Worker { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Manager")]
#else
        [DataMember(Name = "Manager", EmitDefaultValue = false)]
#endif
        public string Manager { get; set; }
    }
}
