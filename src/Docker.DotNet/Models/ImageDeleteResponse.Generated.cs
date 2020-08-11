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
    public class ImageDeleteResponse // (types.ImageDeleteResponseItem)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Deleted")]
#else
        [DataMember(Name = "Deleted", EmitDefaultValue = false)]
#endif
        public string Deleted { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Untagged")]
#else
        [DataMember(Name = "Untagged", EmitDefaultValue = false)]
#endif
        public string Untagged { get; set; }
    }
}
