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
    public class TaskDefaults // (swarm.TaskDefaults)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("LogDriver")]
#else
        [DataMember(Name = "LogDriver", EmitDefaultValue = false)]
#endif
        public SwarmDriver LogDriver { get; set; }
    }
}
