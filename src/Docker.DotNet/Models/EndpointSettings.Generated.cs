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
    public class EndpointSettings // (network.EndpointSettings)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("IPAMConfig")]
#else
        [DataMember(Name = "IPAMConfig", EmitDefaultValue = false)]
#endif
        public EndpointIPAMConfig IPAMConfig { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Links")]
#else
        [DataMember(Name = "Links", EmitDefaultValue = false)]
#endif
        public IList<string> Links { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Aliases")]
#else
        [DataMember(Name = "Aliases", EmitDefaultValue = false)]
#endif
        public IList<string> Aliases { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NetworkID")]
#else
        [DataMember(Name = "NetworkID", EmitDefaultValue = false)]
#endif
        public string NetworkID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("EndpointID")]
#else
        [DataMember(Name = "EndpointID", EmitDefaultValue = false)]
#endif
        public string EndpointID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Gateway")]
#else
        [DataMember(Name = "Gateway", EmitDefaultValue = false)]
#endif
        public string Gateway { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPAddress")]
#else
        [DataMember(Name = "IPAddress", EmitDefaultValue = false)]
#endif
        public string IPAddress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPPrefixLen")]
#else
        [DataMember(Name = "IPPrefixLen", EmitDefaultValue = false)]
#endif
        public long IPPrefixLen { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPv6Gateway")]
#else
        [DataMember(Name = "IPv6Gateway", EmitDefaultValue = false)]
#endif
        public string IPv6Gateway { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GlobalIPv6Address")]
#else
        [DataMember(Name = "GlobalIPv6Address", EmitDefaultValue = false)]
#endif
        public string GlobalIPv6Address { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GlobalIPv6PrefixLen")]
#else
        [DataMember(Name = "GlobalIPv6PrefixLen", EmitDefaultValue = false)]
#endif
        public long GlobalIPv6PrefixLen { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MacAddress")]
#else
        [DataMember(Name = "MacAddress", EmitDefaultValue = false)]
#endif
        public string MacAddress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DriverOpts")]
#else
        [DataMember(Name = "DriverOpts", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> DriverOpts { get; set; }
    }
}
