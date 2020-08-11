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
    public class PluginGetPrivilegeParameters // (main.PluginGetPrivilegeParameters)
    {
        [QueryStringParameter("remote", true)]
        public string Remote { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RegistryAuth")]
#else
        [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
#endif
        public AuthConfig RegistryAuth { get; set; }
    }
}
