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
    public class PluginConfigInterface // (types.PluginConfigInterface)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ProtocolScheme")]
#else
        [DataMember(Name = "ProtocolScheme", EmitDefaultValue = false)]
#endif
        public string ProtocolScheme { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Socket")]
#else
        [DataMember(Name = "Socket", EmitDefaultValue = false)]
#endif
        public string Socket { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Types")]
#else
        [DataMember(Name = "Types", EmitDefaultValue = false)]
#endif
        public IList<string> Types { get; set; }
    }
}
