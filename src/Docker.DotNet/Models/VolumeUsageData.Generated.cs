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
    public class VolumeUsageData // (types.VolumeUsageData)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("RefCount")]
#else
        [DataMember(Name = "RefCount", EmitDefaultValue = false)]
#endif
        public long RefCount { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Size")]
#else
        [DataMember(Name = "Size", EmitDefaultValue = false)]
#endif
        public long Size { get; set; }
    }
}
