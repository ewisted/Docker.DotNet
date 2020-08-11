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
    public class SpreadOver // (swarm.SpreadOver)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("SpreadDescriptor")]
#else
        [DataMember(Name = "SpreadDescriptor", EmitDefaultValue = false)]
#endif
        public string SpreadDescriptor { get; set; }
    }
}
