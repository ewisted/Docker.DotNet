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
    public class BindOptions // (mount.BindOptions)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Propagation")]
#else
        [DataMember(Name = "Propagation", EmitDefaultValue = false)]
#endif
        public string Propagation { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NonRecursive")]
#else
        [DataMember(Name = "NonRecursive", EmitDefaultValue = false)]
#endif
        public bool NonRecursive { get; set; }
    }
}
