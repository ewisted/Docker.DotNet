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
    public class Address // (network.Address)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Addr")]
#else
        [DataMember(Name = "Addr", EmitDefaultValue = false)]
#endif
        public string Addr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PrefixLen")]
#else
        [DataMember(Name = "PrefixLen", EmitDefaultValue = false)]
#endif
        public long PrefixLen { get; set; }
    }
}
