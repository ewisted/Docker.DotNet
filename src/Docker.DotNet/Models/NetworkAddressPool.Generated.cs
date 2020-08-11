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
    public class NetworkAddressPool // (types.NetworkAddressPool)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Base")]
#else
        [DataMember(Name = "Base", EmitDefaultValue = false)]
#endif
        public string Base { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Size")]
#else
        [DataMember(Name = "Size", EmitDefaultValue = false)]
#endif
        public long Size { get; set; }
    }
}
