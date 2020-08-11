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
    public class ConfigReferenceFileTarget // (swarm.ConfigReferenceFileTarget)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("UID")]
#else
        [DataMember(Name = "UID", EmitDefaultValue = false)]
#endif
        public string UID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GID")]
#else
        [DataMember(Name = "GID", EmitDefaultValue = false)]
#endif
        public string GID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mode")]
#else
        [DataMember(Name = "Mode", EmitDefaultValue = false)]
#endif
        public uint Mode { get; set; }
    }
}
