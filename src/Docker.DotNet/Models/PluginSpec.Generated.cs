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
    public class PluginSpec // (runtime.PluginSpec)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("name")]
#else
        [DataMember(Name = "name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("remote")]
#else
        [DataMember(Name = "remote", EmitDefaultValue = false)]
#endif
        public string Remote { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("privileges")]
#else
        [DataMember(Name = "privileges", EmitDefaultValue = false)]
#endif
        public IList<RuntimePluginPrivilege> Privileges { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("disabled")]
#else
        [DataMember(Name = "disabled", EmitDefaultValue = false)]
#endif
        public bool Disabled { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("env")]
#else
        [DataMember(Name = "env", EmitDefaultValue = false)]
#endif
        public IList<string> Env { get; set; }
    }
}
