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
    public class ResourceRequirements // (swarm.ResourceRequirements)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Limits")]
#else
        [DataMember(Name = "Limits", EmitDefaultValue = false)]
#endif
        public Limit Limits { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Reservations")]
#else
        [DataMember(Name = "Reservations", EmitDefaultValue = false)]
#endif
        public SwarmResources Reservations { get; set; }
    }
}
