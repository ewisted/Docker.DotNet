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
    public class ContainerStatus // (swarm.ContainerStatus)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ContainerID")]
#else
        [DataMember(Name = "ContainerID", EmitDefaultValue = false)]
#endif
        public string ContainerID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PID")]
#else
        [DataMember(Name = "PID", EmitDefaultValue = false)]
#endif
        public long PID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ExitCode")]
#else
        [DataMember(Name = "ExitCode", EmitDefaultValue = false)]
#endif
        public long ExitCode { get; set; }
    }
}
