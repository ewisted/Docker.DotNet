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
    public class ImagesSearchParameters // (main.ImagesSearchParameters)
    {
        [QueryStringParameter("term", false)]
        public string Term { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RegistryAuth")]
#else
        [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
#endif
        public AuthConfig RegistryAuth { get; set; }
    }
}
