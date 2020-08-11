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
    public class VolumesPruneResponse // (types.VolumesPruneReport)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("VolumesDeleted")]
#else
        [DataMember(Name = "VolumesDeleted", EmitDefaultValue = false)]
#endif
        public IList<string> VolumesDeleted { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SpaceReclaimed")]
#else
        [DataMember(Name = "SpaceReclaimed", EmitDefaultValue = false)]
#endif
        public ulong SpaceReclaimed { get; set; }
    }
}
