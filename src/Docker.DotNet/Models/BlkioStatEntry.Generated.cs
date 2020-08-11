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
    public class BlkioStatEntry // (types.BlkioStatEntry)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("major")]
#else
        [DataMember(Name = "major", EmitDefaultValue = false)]
#endif
        public ulong Major { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("minor")]
#else
        [DataMember(Name = "minor", EmitDefaultValue = false)]
#endif
        public ulong Minor { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("op")]
#else
        [DataMember(Name = "op", EmitDefaultValue = false)]
#endif
        public string Op { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("value")]
#else
        [DataMember(Name = "value", EmitDefaultValue = false)]
#endif
        public ulong Value { get; set; }
    }
}
