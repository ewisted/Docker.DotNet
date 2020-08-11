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
    public class ServiceUpdateParameters // (main.ServiceUpdateParameters)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Service")]
#else
        [DataMember(Name = "Service", EmitDefaultValue = false)]
#endif
        public ServiceSpec Service { get; set; }

        [QueryStringParameter("version", true)]
        public long Version { get; set; }

        [QueryStringParameter("registryauthfrom", false)]
        public string RegistryAuthFrom { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RegistryAuth")]
#else
        [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
#endif
        public AuthConfig RegistryAuth { get; set; }
    }
}
