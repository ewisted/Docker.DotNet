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
    public class UpdateStatus // (swarm.UpdateStatus)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("State")]
#else
        [DataMember(Name = "State", EmitDefaultValue = false)]
#endif
        public string State { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("StartedAt")]
#else
        [DataMember(Name = "StartedAt", EmitDefaultValue = false)]
#endif
        public DateTime? StartedAt { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CompletedAt")]
#else
        [DataMember(Name = "CompletedAt", EmitDefaultValue = false)]
#endif
        public DateTime? CompletedAt { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Message")]
#else
        [DataMember(Name = "Message", EmitDefaultValue = false)]
#endif
        public string Message { get; set; }
    }
}
