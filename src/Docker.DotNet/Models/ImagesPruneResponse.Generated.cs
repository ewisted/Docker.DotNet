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
    public class ImagesPruneResponse // (types.ImagesPruneReport)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ImagesDeleted")]
#else
        [DataMember(Name = "ImagesDeleted", EmitDefaultValue = false)]
#endif
        public IList<ImageDeleteResponse> ImagesDeleted { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SpaceReclaimed")]
#else
        [DataMember(Name = "SpaceReclaimed", EmitDefaultValue = false)]
#endif
        public ulong SpaceReclaimed { get; set; }
    }
}
