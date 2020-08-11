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
    public class SELinuxContext // (swarm.SELinuxContext)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Disable")]
#else
        [DataMember(Name = "Disable", EmitDefaultValue = false)]
#endif
        public bool Disable { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("User")]
#else
        [DataMember(Name = "User", EmitDefaultValue = false)]
#endif
        public string User { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Role")]
#else
        [DataMember(Name = "Role", EmitDefaultValue = false)]
#endif
        public string Role { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Type")]
#else
        [DataMember(Name = "Type", EmitDefaultValue = false)]
#endif
        public string Type { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Level")]
#else
        [DataMember(Name = "Level", EmitDefaultValue = false)]
#endif
        public string Level { get; set; }
    }
}
