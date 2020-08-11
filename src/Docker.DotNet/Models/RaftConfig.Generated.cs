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
    public class RaftConfig // (swarm.RaftConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("SnapshotInterval")]
#else
        [DataMember(Name = "SnapshotInterval", EmitDefaultValue = false)]
#endif
        public ulong SnapshotInterval { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("KeepOldSnapshots")]
#else
        [DataMember(Name = "KeepOldSnapshots", EmitDefaultValue = false)]
#endif
        public ulong? KeepOldSnapshots { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LogEntriesForSlowFollowers")]
#else
        [DataMember(Name = "LogEntriesForSlowFollowers", EmitDefaultValue = false)]
#endif
        public ulong LogEntriesForSlowFollowers { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ElectionTick")]
#else
        [DataMember(Name = "ElectionTick", EmitDefaultValue = false)]
#endif
        public long ElectionTick { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("HeartbeatTick")]
#else
        [DataMember(Name = "HeartbeatTick", EmitDefaultValue = false)]
#endif
        public long HeartbeatTick { get; set; }
    }
}
