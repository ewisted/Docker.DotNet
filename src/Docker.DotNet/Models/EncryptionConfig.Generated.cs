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
    public class EncryptionConfig // (swarm.EncryptionConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("AutoLockManagers")]
#else
        [DataMember(Name = "AutoLockManagers", EmitDefaultValue = false)]
#endif
        public bool AutoLockManagers { get; set; }
    }
}
