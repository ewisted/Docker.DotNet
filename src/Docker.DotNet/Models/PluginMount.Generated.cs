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
    public class PluginMount // (types.PluginMount)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Description")]
#else
        [DataMember(Name = "Description", EmitDefaultValue = false)]
#endif
        public string Description { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Destination")]
#else
        [DataMember(Name = "Destination", EmitDefaultValue = false)]
#endif
        public string Destination { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Options")]
#else
        [DataMember(Name = "Options", EmitDefaultValue = false)]
#endif
        public IList<string> Options { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Settable")]
#else
        [DataMember(Name = "Settable", EmitDefaultValue = false)]
#endif
        public IList<string> Settable { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Source")]
#else
        [DataMember(Name = "Source", EmitDefaultValue = false)]
#endif
        public string Source { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Type")]
#else
        [DataMember(Name = "Type", EmitDefaultValue = false)]
#endif
        public string Type { get; set; }
    }
}
