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
    public class NetworkingConfig // (network.NetworkingConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("EndpointsConfig")]
#else
        [DataMember(Name = "EndpointsConfig", EmitDefaultValue = false)]
#endif
        public IDictionary<string, EndpointSettings> EndpointsConfig { get; set; }
    }
}
