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
    public class Port // (types.Port)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("IP")]
#else
        [DataMember(Name = "IP", EmitDefaultValue = false)]
#endif
        public string IP { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PrivatePort")]
#else
        [DataMember(Name = "PrivatePort", EmitDefaultValue = false)]
#endif
        public ushort PrivatePort { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PublicPort")]
#else
        [DataMember(Name = "PublicPort", EmitDefaultValue = false)]
#endif
        public ushort PublicPort { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Type")]
#else
        [DataMember(Name = "Type", EmitDefaultValue = false)]
#endif
        public string Type { get; set; }
    }
}
