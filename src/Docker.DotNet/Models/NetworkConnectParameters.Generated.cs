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
    public class NetworkConnectParameters // (types.NetworkConnect)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Container")]
#else
        [DataMember(Name = "Container", EmitDefaultValue = false)]
#endif
        public string Container { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("EndpointConfig")]
#else
        [DataMember(Name = "EndpointConfig", EmitDefaultValue = false)]
#endif
        public EndpointSettings EndpointConfig { get; set; }
    }
}
