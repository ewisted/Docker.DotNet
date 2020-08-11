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
    public class Plugin // (types.Plugin)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Config")]
#else
        [DataMember(Name = "Config", EmitDefaultValue = false)]
#endif
        public PluginConfig Config { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Enabled")]
#else
        [DataMember(Name = "Enabled", EmitDefaultValue = false)]
#endif
        public bool Enabled { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Id")]
#else
        [DataMember(Name = "Id", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PluginReference")]
#else
        [DataMember(Name = "PluginReference", EmitDefaultValue = false)]
#endif
        public string PluginReference { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Settings")]
#else
        [DataMember(Name = "Settings", EmitDefaultValue = false)]
#endif
        public PluginSettings Settings { get; set; }
    }
}
