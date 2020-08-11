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
    public class Info // (swarm.Info)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("NodeID")]
#else
        [DataMember(Name = "NodeID", EmitDefaultValue = false)]
#endif
        public string NodeID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NodeAddr")]
#else
        [DataMember(Name = "NodeAddr", EmitDefaultValue = false)]
#endif
        public string NodeAddr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LocalNodeState")]
#else
        [DataMember(Name = "LocalNodeState", EmitDefaultValue = false)]
#endif
        public string LocalNodeState { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ControlAvailable")]
#else
        [DataMember(Name = "ControlAvailable", EmitDefaultValue = false)]
#endif
        public bool ControlAvailable { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Error")]
#else
        [DataMember(Name = "Error", EmitDefaultValue = false)]
#endif
        public string Error { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RemoteManagers")]
#else
        [DataMember(Name = "RemoteManagers", EmitDefaultValue = false)]
#endif
        public IList<Peer> RemoteManagers { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Nodes")]
#else
        [DataMember(Name = "Nodes", EmitDefaultValue = false)]
#endif
        public long Nodes { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Managers")]
#else
        [DataMember(Name = "Managers", EmitDefaultValue = false)]
#endif
        public long Managers { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Cluster")]
#else
        [DataMember(Name = "Cluster", EmitDefaultValue = false)]
#endif
        public ClusterInfo Cluster { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Warnings")]
#else
        [DataMember(Name = "Warnings", EmitDefaultValue = false)]
#endif
        public IList<string> Warnings { get; set; }
    }
}
