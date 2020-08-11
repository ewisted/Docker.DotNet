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
    public class EngineDescription // (swarm.EngineDescription)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("EngineVersion")]
#else
        [DataMember(Name = "EngineVersion", EmitDefaultValue = false)]
#endif
        public string EngineVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Plugins")]
#else
        [DataMember(Name = "Plugins", EmitDefaultValue = false)]
#endif
        public IList<PluginDescription> Plugins { get; set; }
    }
}
