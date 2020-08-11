using System;
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
    public class TaskStatus // (swarm.TaskStatus)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Timestamp")]
#else
        [DataMember(Name = "Timestamp", EmitDefaultValue = false)]
#endif
        public DateTime Timestamp { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("State")]
#else
        [DataMember(Name = "State", EmitDefaultValue = false)]
#endif
        public TaskState State { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Message")]
#else
        [DataMember(Name = "Message", EmitDefaultValue = false)]
#endif
        public string Message { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Err")]
#else
        [DataMember(Name = "Err", EmitDefaultValue = false)]
#endif
        public string Err { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ContainerStatus")]
#else
        [DataMember(Name = "ContainerStatus", EmitDefaultValue = false)]
#endif
        public ContainerStatus ContainerStatus { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PortStatus")]
#else
        [DataMember(Name = "PortStatus", EmitDefaultValue = false)]
#endif
        public PortStatus PortStatus { get; set; }
    }
}
