using System.Collections.Generic;
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
    public class Placement // (swarm.Placement)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Constraints")]
#else
        [DataMember(Name = "Constraints", EmitDefaultValue = false)]
#endif
        public IList<string> Constraints { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Preferences")]
#else
        [DataMember(Name = "Preferences", EmitDefaultValue = false)]
#endif
        public IList<PlacementPreference> Preferences { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MaxReplicas")]
#else
        [DataMember(Name = "MaxReplicas", EmitDefaultValue = false)]
#endif
        public ulong MaxReplicas { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Platforms")]
#else
        [DataMember(Name = "Platforms", EmitDefaultValue = false)]
#endif
        public IList<Platform> Platforms { get; set; }
    }
}
