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
    public class PluginDevice // (types.PluginDevice)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Description")]
#else
        [DataMember(Name = "Description", EmitDefaultValue = false)]
#endif
        public string Description { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Path")]
#else
        [DataMember(Name = "Path", EmitDefaultValue = false)]
#endif
        public string Path { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Settable")]
#else
        [DataMember(Name = "Settable", EmitDefaultValue = false)]
#endif
        public IList<string> Settable { get; set; }
    }
}
