using System.Collections.Generic;
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
    public class CPUUsage // (types.CPUUsage)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("total_usage")]
#else
        [DataMember(Name = "total_usage", EmitDefaultValue = false)]
#endif
        public ulong TotalUsage { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("percpu_usage")]
#else
        [DataMember(Name = "percpu_usage", EmitDefaultValue = false)]
#endif
        public IList<ulong> PercpuUsage { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("usage_in_kernelmode")]
#else
        [DataMember(Name = "usage_in_kernelmode", EmitDefaultValue = false)]
#endif
        public ulong UsageInKernelmode { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("usage_in_usermode")]
#else
        [DataMember(Name = "usage_in_usermode", EmitDefaultValue = false)]
#endif
        public ulong UsageInUsermode { get; set; }
    }
}
