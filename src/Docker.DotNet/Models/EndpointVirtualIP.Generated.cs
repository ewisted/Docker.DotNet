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
    public class EndpointVirtualIP // (swarm.EndpointVirtualIP)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("NetworkID")]
#else
        [DataMember(Name = "NetworkID", EmitDefaultValue = false)]
#endif
        public string NetworkID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Addr")]
#else
        [DataMember(Name = "Addr", EmitDefaultValue = false)]
#endif
        public string Addr { get; set; }
    }
}
