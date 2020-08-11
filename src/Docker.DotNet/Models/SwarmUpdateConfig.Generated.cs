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
    public class SwarmUpdateConfig // (swarm.UpdateConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Parallelism")]
#else
        [DataMember(Name = "Parallelism", EmitDefaultValue = false)]
#endif
        public ulong Parallelism { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Delay")]
#else
        [DataMember(Name = "Delay", EmitDefaultValue = false)]
#endif
        public long Delay { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("FailureAction")]
#else
        [DataMember(Name = "FailureAction", EmitDefaultValue = false)]
#endif
        public string FailureAction { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Monitor")]
#else
        [DataMember(Name = "Monitor", EmitDefaultValue = false)]
#endif
        public long Monitor { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MaxFailureRatio")]
#else
        [DataMember(Name = "MaxFailureRatio", EmitDefaultValue = false)]
#endif
        public float MaxFailureRatio { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Order")]
#else
        [DataMember(Name = "Order", EmitDefaultValue = false)]
#endif
        public string Order { get; set; }
    }
}
