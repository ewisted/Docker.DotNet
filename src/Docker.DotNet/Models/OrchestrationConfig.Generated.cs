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
    public class OrchestrationConfig // (swarm.OrchestrationConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("TaskHistoryRetentionLimit")]
#else
        [DataMember(Name = "TaskHistoryRetentionLimit", EmitDefaultValue = false)]
#endif
        public long? TaskHistoryRetentionLimit { get; set; }
    }
}
