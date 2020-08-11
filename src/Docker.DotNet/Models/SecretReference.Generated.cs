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
    public class SecretReference // (swarm.SecretReference)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("File")]
#else
        [DataMember(Name = "File", EmitDefaultValue = false)]
#endif
        public SecretReferenceFileTarget File { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SecretID")]
#else
        [DataMember(Name = "SecretID", EmitDefaultValue = false)]
#endif
        public string SecretID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SecretName")]
#else
        [DataMember(Name = "SecretName", EmitDefaultValue = false)]
#endif
        public string SecretName { get; set; }
    }
}
