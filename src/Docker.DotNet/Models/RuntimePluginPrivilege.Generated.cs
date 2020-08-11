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
    public class RuntimePluginPrivilege // (runtime.PluginPrivilege)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("name")]
#else
        [DataMember(Name = "name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("description")]
#else
        [DataMember(Name = "description", EmitDefaultValue = false)]
#endif
        public string Description { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("value")]
#else
        [DataMember(Name = "value", EmitDefaultValue = false)]
#endif
        public IList<string> Value { get; set; }
    }
}
