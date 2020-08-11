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
    public class ReplicatedJob // (swarm.ReplicatedJob)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("MaxConcurrent")]
#else
        [DataMember(Name = "MaxConcurrent", EmitDefaultValue = false)]
#endif
        public ulong? MaxConcurrent { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("TotalCompletions")]
#else
        [DataMember(Name = "TotalCompletions", EmitDefaultValue = false)]
#endif
        public ulong? TotalCompletions { get; set; }
    }
}
