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
    public class CredentialSpec // (swarm.CredentialSpec)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Config")]
#else
        [DataMember(Name = "Config", EmitDefaultValue = false)]
#endif
        public string Config { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("File")]
#else
        [DataMember(Name = "File", EmitDefaultValue = false)]
#endif
        public string File { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Registry")]
#else
        [DataMember(Name = "Registry", EmitDefaultValue = false)]
#endif
        public string Registry { get; set; }
    }
}
