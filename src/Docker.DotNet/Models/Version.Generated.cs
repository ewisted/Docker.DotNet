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
    public class Version // (swarm.Version)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Index")]
#else
        [DataMember(Name = "Index", EmitDefaultValue = false)]
#endif
        public ulong Index { get; set; }
    }
}
