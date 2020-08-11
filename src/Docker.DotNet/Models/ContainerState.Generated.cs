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
    public class ContainerState // (types.ContainerState)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Status")]
#else
        [DataMember(Name = "Status", EmitDefaultValue = false)]
#endif
        public string Status { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Running")]
#else
        [DataMember(Name = "Running", EmitDefaultValue = false)]
#endif
        public bool Running { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Paused")]
#else
        [DataMember(Name = "Paused", EmitDefaultValue = false)]
#endif
        public bool Paused { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Restarting")]
#else
        [DataMember(Name = "Restarting", EmitDefaultValue = false)]
#endif
        public bool Restarting { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OOMKilled")]
#else
        [DataMember(Name = "OOMKilled", EmitDefaultValue = false)]
#endif
        public bool OOMKilled { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Dead")]
#else
        [DataMember(Name = "Dead", EmitDefaultValue = false)]
#endif
        public bool Dead { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Pid")]
#else
        [DataMember(Name = "Pid", EmitDefaultValue = false)]
#endif
        public long Pid { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ExitCode")]
#else
        [DataMember(Name = "ExitCode", EmitDefaultValue = false)]
#endif
        public long ExitCode { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Error")]
#else
        [DataMember(Name = "Error", EmitDefaultValue = false)]
#endif
        public string Error { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("StartedAt")]
#else
        [DataMember(Name = "StartedAt", EmitDefaultValue = false)]
#endif
        public string StartedAt { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("FinishedAt")]
#else
        [DataMember(Name = "FinishedAt", EmitDefaultValue = false)]
#endif
        public string FinishedAt { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Health")]
#else
        [DataMember(Name = "Health", EmitDefaultValue = false)]
#endif
        public Health Health { get; set; }
    }
}
