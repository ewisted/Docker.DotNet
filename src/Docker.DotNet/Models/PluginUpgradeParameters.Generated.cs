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
    public class PluginUpgradeParameters // (main.PluginUpgradeParameters)
    {
        [QueryStringParameter("remote", true)]
        public string Remote { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RegistryAuth")]
#else
        [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
#endif
        public AuthConfig RegistryAuth { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Privileges")]
#else
        [DataMember(Name = "Privileges", EmitDefaultValue = false)]
#endif
        public IList<PluginPrivilege> Privileges { get; set; }
    }
}
