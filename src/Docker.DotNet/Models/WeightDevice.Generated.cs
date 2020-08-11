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
    public class WeightDevice // (blkiodev.WeightDevice)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Path")]
#else
        [DataMember(Name = "Path", EmitDefaultValue = false)]
#endif
        public string Path { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Weight")]
#else
        [DataMember(Name = "Weight", EmitDefaultValue = false)]
#endif
        public ushort Weight { get; set; }
    }
}
