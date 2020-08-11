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
    public class PlacementPreference // (swarm.PlacementPreference)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Spread")]
#else
        [DataMember(Name = "Spread", EmitDefaultValue = false)]
#endif
        public SpreadOver Spread { get; set; }
    }
}
