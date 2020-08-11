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
    public class GenericResource // (swarm.GenericResource)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("NamedResourceSpec")]
#else
        [DataMember(Name = "NamedResourceSpec", EmitDefaultValue = false)]
#endif
        public NamedGenericResource NamedResourceSpec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DiscreteResourceSpec")]
#else
        [DataMember(Name = "DiscreteResourceSpec", EmitDefaultValue = false)]
#endif
        public DiscreteGenericResource DiscreteResourceSpec { get; set; }
    }
}
