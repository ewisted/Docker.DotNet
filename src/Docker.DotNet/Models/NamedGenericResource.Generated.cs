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
    public class NamedGenericResource // (swarm.NamedGenericResource)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Kind")]
#else
        [DataMember(Name = "Kind", EmitDefaultValue = false)]
#endif
        public string Kind { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Value")]
#else
        [DataMember(Name = "Value", EmitDefaultValue = false)]
#endif
        public string Value { get; set; }
    }
}
