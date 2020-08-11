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
    public class PluginDescription // (swarm.PluginDescription)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Type")]
#else
        [DataMember(Name = "Type", EmitDefaultValue = false)]
#endif
        public string Type { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }
    }
}
