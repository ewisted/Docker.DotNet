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
    public class ThrottleDevice // (blkiodev.ThrottleDevice)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Path")]
#else
        [DataMember(Name = "Path", EmitDefaultValue = false)]
#endif
        public string Path { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Rate")]
#else
        [DataMember(Name = "Rate", EmitDefaultValue = false)]
#endif
        public ulong Rate { get; set; }
    }
}
