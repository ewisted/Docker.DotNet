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
    public class ServiceCreateParameters // (main.ServiceCreateParameters)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Service")]
#else
        [DataMember(Name = "Service", EmitDefaultValue = false)]
#endif
        public ServiceSpec Service { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RegistryAuth")]
#else
        [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
#endif
        public AuthConfig RegistryAuth { get; set; }
    }
}
