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
    public class ServiceMode // (swarm.ServiceMode)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Replicated")]
#else
        [DataMember(Name = "Replicated", EmitDefaultValue = false)]
#endif
        public ReplicatedService Replicated { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Global")]
#else
        [DataMember(Name = "Global", EmitDefaultValue = false)]
#endif
        public GlobalService Global { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ReplicatedJob")]
#else
        [DataMember(Name = "ReplicatedJob", EmitDefaultValue = false)]
#endif
        public ReplicatedJob ReplicatedJob { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GlobalJob")]
#else
        [DataMember(Name = "GlobalJob", EmitDefaultValue = false)]
#endif
        public GlobalJob GlobalJob { get; set; }
    }
}
