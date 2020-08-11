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
    public class DispatcherConfig // (swarm.DispatcherConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("HeartbeatPeriod")]
#else
        [DataMember(Name = "HeartbeatPeriod", EmitDefaultValue = false)]
#endif
        public long HeartbeatPeriod { get; set; }
    }
}
