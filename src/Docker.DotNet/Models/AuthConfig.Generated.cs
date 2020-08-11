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
    public class AuthConfig // (types.AuthConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("username")]
#else
        [DataMember(Name = "username", EmitDefaultValue = false)]
#endif
        public string Username { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("password")]
#else
        [DataMember(Name = "password", EmitDefaultValue = false)]
#endif
        public string Password { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("auth")]
#else
        [DataMember(Name = "auth", EmitDefaultValue = false)]
#endif
        public string Auth { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("email")]
#else
        [DataMember(Name = "email", EmitDefaultValue = false)]
#endif
        public string Email { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("serveraddress")]
#else
        [DataMember(Name = "serveraddress", EmitDefaultValue = false)]
#endif
        public string ServerAddress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("identitytoken")]
#else
        [DataMember(Name = "identitytoken", EmitDefaultValue = false)]
#endif
        public string IdentityToken { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("registrytoken")]
#else
        [DataMember(Name = "registrytoken", EmitDefaultValue = false)]
#endif
        public string RegistryToken { get; set; }
    }
}
