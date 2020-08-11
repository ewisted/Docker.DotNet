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
    public class ImageBuildResponse // (types.ImageBuildResponse)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Body")]
#else
        [DataMember(Name = "Body", EmitDefaultValue = false)]
#endif
        public object Body { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OSType")]
#else
        [DataMember(Name = "OSType", EmitDefaultValue = false)]
#endif
        public string OSType { get; set; }
    }
}
