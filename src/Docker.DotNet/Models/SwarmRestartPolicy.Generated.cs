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
    public class SwarmRestartPolicy // (swarm.RestartPolicy)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Condition")]
#else
        [DataMember(Name = "Condition", EmitDefaultValue = false)]
#endif
        public string Condition { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Delay")]
#else
        [DataMember(Name = "Delay", EmitDefaultValue = false)]
#endif
        public long? Delay { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MaxAttempts")]
#else
        [DataMember(Name = "MaxAttempts", EmitDefaultValue = false)]
#endif
        public ulong? MaxAttempts { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Window")]
#else
        [DataMember(Name = "Window", EmitDefaultValue = false)]
#endif
        public long? Window { get; set; }
    }
}
