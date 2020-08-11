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
    public class ServiceStatus // (swarm.ServiceStatus)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("RunningTasks")]
#else
        [DataMember(Name = "RunningTasks", EmitDefaultValue = false)]
#endif
        public ulong RunningTasks { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DesiredTasks")]
#else
        [DataMember(Name = "DesiredTasks", EmitDefaultValue = false)]
#endif
        public ulong DesiredTasks { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CompletedTasks")]
#else
        [DataMember(Name = "CompletedTasks", EmitDefaultValue = false)]
#endif
        public ulong CompletedTasks { get; set; }
    }
}
