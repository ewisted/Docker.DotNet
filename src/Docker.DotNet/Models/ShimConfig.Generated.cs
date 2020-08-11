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
    public class ShimConfig // (types.ShimConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Binary")]
#else
        [DataMember(Name = "Binary", EmitDefaultValue = false)]
#endif
        public string Binary { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Opts")]
#else
        [DataMember(Name = "Opts", EmitDefaultValue = false)]
#endif
        public object Opts { get; set; }
    }
}
