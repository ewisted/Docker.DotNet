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
    public class ComponentVersion // (types.ComponentVersion)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Version")]
#else
        [DataMember(Name = "Version", EmitDefaultValue = false)]
#endif
        public string Version { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Details")]
#else
        [DataMember(Name = "Details", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Details { get; set; }
    }
}
