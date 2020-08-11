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
    public class TmpfsOptions // (mount.TmpfsOptions)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("SizeBytes")]
#else
        [DataMember(Name = "SizeBytes", EmitDefaultValue = false)]
#endif
        public long SizeBytes { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mode")]
#else
        [DataMember(Name = "Mode", EmitDefaultValue = false)]
#endif
        public uint Mode { get; set; }
    }
}
