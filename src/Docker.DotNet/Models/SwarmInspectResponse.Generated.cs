using System;
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
    public class SwarmInspectResponse // (swarm.Swarm)
    {
        public SwarmInspectResponse()
        {
        }

        public SwarmInspectResponse(ClusterInfo ClusterInfo)
        {
            if (ClusterInfo != null)
            {
                this.ID = ClusterInfo.ID;
                this.Version = ClusterInfo.Version;
                this.CreatedAt = ClusterInfo.CreatedAt;
                this.UpdatedAt = ClusterInfo.UpdatedAt;
                this.Spec = ClusterInfo.Spec;
                this.TLSInfo = ClusterInfo.TLSInfo;
                this.RootRotationInProgress = ClusterInfo.RootRotationInProgress;
                this.DefaultAddrPool = ClusterInfo.DefaultAddrPool;
                this.SubnetSize = ClusterInfo.SubnetSize;
                this.DataPathPort = ClusterInfo.DataPathPort;
            }
        }

#if NETSTANDARD2_1
        [JsonPropertyName("ID")]
#else
        [DataMember(Name = "ID", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Version")]
#else
        [DataMember(Name = "Version", EmitDefaultValue = false)]
#endif
        public Version Version { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CreatedAt")]
#else
        [DataMember(Name = "CreatedAt", EmitDefaultValue = false)]
#endif
        public DateTime CreatedAt { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("UpdatedAt")]
#else
        [DataMember(Name = "UpdatedAt", EmitDefaultValue = false)]
#endif
        public DateTime UpdatedAt { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Spec")]
#else
        [DataMember(Name = "Spec", EmitDefaultValue = false)]
#endif
        public Spec Spec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("TLSInfo")]
#else
        [DataMember(Name = "TLSInfo", EmitDefaultValue = false)]
#endif
        public TLSInfo TLSInfo { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RootRotationInProgress")]
#else
        [DataMember(Name = "RootRotationInProgress", EmitDefaultValue = false)]
#endif
        public bool RootRotationInProgress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DefaultAddrPool")]
#else
        [DataMember(Name = "DefaultAddrPool", EmitDefaultValue = false)]
#endif
        public IList<string> DefaultAddrPool { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SubnetSize")]
#else
        [DataMember(Name = "SubnetSize", EmitDefaultValue = false)]
#endif
        public uint SubnetSize { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DataPathPort")]
#else
        [DataMember(Name = "DataPathPort", EmitDefaultValue = false)]
#endif
        public uint DataPathPort { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("JoinTokens")]
#else
        [DataMember(Name = "JoinTokens", EmitDefaultValue = false)]
#endif
        public JoinTokens JoinTokens { get; set; }
    }
}
