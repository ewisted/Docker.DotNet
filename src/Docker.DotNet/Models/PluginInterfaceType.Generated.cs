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
    public class PluginInterfaceType // (types.PluginInterfaceType)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Capability")]
#else
        [DataMember(Name = "Capability", EmitDefaultValue = false)]
#endif
        public string Capability { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Prefix")]
#else
        [DataMember(Name = "Prefix", EmitDefaultValue = false)]
#endif
        public string Prefix { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Version")]
#else
        [DataMember(Name = "Version", EmitDefaultValue = false)]
#endif
        public string Version { get; set; }
    }
}
