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
    public class NetworkStats // (types.NetworkStats)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("rx_bytes")]
#else
        [DataMember(Name = "rx_bytes", EmitDefaultValue = false)]
#endif
        public ulong RxBytes { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("rx_packets")]
#else
        [DataMember(Name = "rx_packets", EmitDefaultValue = false)]
#endif
        public ulong RxPackets { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("rx_errors")]
#else
        [DataMember(Name = "rx_errors", EmitDefaultValue = false)]
#endif
        public ulong RxErrors { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("rx_dropped")]
#else
        [DataMember(Name = "rx_dropped", EmitDefaultValue = false)]
#endif
        public ulong RxDropped { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("tx_bytes")]
#else
        [DataMember(Name = "tx_bytes", EmitDefaultValue = false)]
#endif
        public ulong TxBytes { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("tx_packets")]
#else
        [DataMember(Name = "tx_packets", EmitDefaultValue = false)]
#endif
        public ulong TxPackets { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("tx_errors")]
#else
        [DataMember(Name = "tx_errors", EmitDefaultValue = false)]
#endif
        public ulong TxErrors { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("tx_dropped")]
#else
        [DataMember(Name = "tx_dropped", EmitDefaultValue = false)]
#endif
        public ulong TxDropped { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("endpoint_id")]
#else
        [DataMember(Name = "endpoint_id", EmitDefaultValue = false)]
#endif
        public string EndpointID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("instance_id")]
#else
        [DataMember(Name = "instance_id", EmitDefaultValue = false)]
#endif
        public string InstanceID { get; set; }
    }
}
