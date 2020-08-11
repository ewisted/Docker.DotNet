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
    public class EndpointResource // (types.EndpointResource)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("EndpointID")]
#else
        [DataMember(Name = "EndpointID", EmitDefaultValue = false)]
#endif
        public string EndpointID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MacAddress")]
#else
        [DataMember(Name = "MacAddress", EmitDefaultValue = false)]
#endif
        public string MacAddress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPv4Address")]
#else
        [DataMember(Name = "IPv4Address", EmitDefaultValue = false)]
#endif
        public string IPv4Address { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPv6Address")]
#else
        [DataMember(Name = "IPv6Address", EmitDefaultValue = false)]
#endif
        public string IPv6Address { get; set; }
    }
}
