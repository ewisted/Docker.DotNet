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
    public class NetworkDisconnectParameters // (types.NetworkDisconnect)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Container")]
#else
        [DataMember(Name = "Container", EmitDefaultValue = false)]
#endif
        public string Container { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Force")]
#else
        [DataMember(Name = "Force", EmitDefaultValue = false)]
#endif
        public bool Force { get; set; }
    }
}
