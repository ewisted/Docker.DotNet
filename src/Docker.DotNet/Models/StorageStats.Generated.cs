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
    public class StorageStats // (types.StorageStats)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("read_count_normalized")]
#else
        [DataMember(Name = "read_count_normalized", EmitDefaultValue = false)]
#endif
        public ulong ReadCountNormalized { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("read_size_bytes")]
#else
        [DataMember(Name = "read_size_bytes", EmitDefaultValue = false)]
#endif
        public ulong ReadSizeBytes { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("write_count_normalized")]
#else
        [DataMember(Name = "write_count_normalized", EmitDefaultValue = false)]
#endif
        public ulong WriteCountNormalized { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("write_size_bytes")]
#else
        [DataMember(Name = "write_size_bytes", EmitDefaultValue = false)]
#endif
        public ulong WriteSizeBytes { get; set; }
    }
}
