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
    public class IndexInfo // (registry.IndexInfo)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mirrors")]
#else
        [DataMember(Name = "Mirrors", EmitDefaultValue = false)]
#endif
        public IList<string> Mirrors { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Secure")]
#else
        [DataMember(Name = "Secure", EmitDefaultValue = false)]
#endif
        public bool Secure { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Official")]
#else
        [DataMember(Name = "Official", EmitDefaultValue = false)]
#endif
        public bool Official { get; set; }
    }
}
