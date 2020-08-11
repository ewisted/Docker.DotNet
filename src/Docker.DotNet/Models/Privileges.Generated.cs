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
    public class Privileges // (swarm.Privileges)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("CredentialSpec")]
#else
        [DataMember(Name = "CredentialSpec", EmitDefaultValue = false)]
#endif
        public CredentialSpec CredentialSpec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SELinuxContext")]
#else
        [DataMember(Name = "SELinuxContext", EmitDefaultValue = false)]
#endif
        public SELinuxContext SELinuxContext { get; set; }
    }
}
