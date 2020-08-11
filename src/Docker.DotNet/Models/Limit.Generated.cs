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
    public class Limit // (swarm.Limit)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("NanoCPUs")]
#else
        [DataMember(Name = "NanoCPUs", EmitDefaultValue = false)]
#endif
        public long NanoCPUs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MemoryBytes")]
#else
        [DataMember(Name = "MemoryBytes", EmitDefaultValue = false)]
#endif
        public long MemoryBytes { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Pids")]
#else
        [DataMember(Name = "Pids", EmitDefaultValue = false)]
#endif
        public long Pids { get; set; }
    }
}
