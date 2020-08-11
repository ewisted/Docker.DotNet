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
    public class SwarmConfigReference // (swarm.ConfigReference)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("File")]
#else
        [DataMember(Name = "File", EmitDefaultValue = false)]
#endif
        public ConfigReferenceFileTarget File { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Runtime")]
#else
        [DataMember(Name = "Runtime", EmitDefaultValue = false)]
#endif
        public ConfigReferenceRuntimeTarget Runtime { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ConfigID")]
#else
        [DataMember(Name = "ConfigID", EmitDefaultValue = false)]
#endif
        public string ConfigID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ConfigName")]
#else
        [DataMember(Name = "ConfigName", EmitDefaultValue = false)]
#endif
        public string ConfigName { get; set; }
    }
}
