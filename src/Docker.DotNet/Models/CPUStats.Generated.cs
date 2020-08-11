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
    public class CPUStats // (types.CPUStats)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("cpu_usage")]
#else
        [DataMember(Name = "cpu_usage", EmitDefaultValue = false)]
#endif
        public CPUUsage CPUUsage { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("system_cpu_usage")]
#else
        [DataMember(Name = "system_cpu_usage", EmitDefaultValue = false)]
#endif
        public ulong SystemUsage { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("online_cpus")]
#else
        [DataMember(Name = "online_cpus", EmitDefaultValue = false)]
#endif
        public uint OnlineCPUs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("throttling_data")]
#else
        [DataMember(Name = "throttling_data", EmitDefaultValue = false)]
#endif
        public ThrottlingData ThrottlingData { get; set; }
    }
}
