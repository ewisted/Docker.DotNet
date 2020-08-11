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
    public class NetworksCreateResponse // (types.NetworkCreateResponse)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Id")]
#else
        [DataMember(Name = "Id", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Warning")]
#else
        [DataMember(Name = "Warning", EmitDefaultValue = false)]
#endif
        public string Warning { get; set; }
    }
}
