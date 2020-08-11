using System.Collections.Generic;
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
    public class SwarmResources // (swarm.Resources)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("NanoCPUs")]
#else
        [DataMember(Name = "NanoCPUs", EmitDefaultValue = false)]
#endif
        public long NanoCPUs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MemoryBytes")]
#else
        [DataMember(Name = "MemoryBytes", EmitDefaultValue = false)]
#endif
        public long MemoryBytes { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GenericResources")]
#else
        [DataMember(Name = "GenericResources", EmitDefaultValue = false)]
#endif
        public IList<GenericResource> GenericResources { get; set; }
    }
}
