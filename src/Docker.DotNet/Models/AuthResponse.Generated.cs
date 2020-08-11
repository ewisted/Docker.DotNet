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
    public class AuthResponse // (registry.AuthenticateOKBody)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("IdentityToken")]
#else
        [DataMember(Name = "IdentityToken", EmitDefaultValue = false)]
#endif
        public string IdentityToken { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Status")]
#else
        [DataMember(Name = "Status", EmitDefaultValue = false)]
#endif
        public string Status { get; set; }
    }
}
