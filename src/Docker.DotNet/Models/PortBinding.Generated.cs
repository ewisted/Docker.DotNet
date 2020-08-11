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
    public class PortBinding // (nat.PortBinding)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("HostIp")]
#else
        [DataMember(Name = "HostIp", EmitDefaultValue = false)]
#endif
        public string HostIP { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("HostPort")]
#else
        [DataMember(Name = "HostPort", EmitDefaultValue = false)]
#endif
        public string HostPort { get; set; }
    }
}
