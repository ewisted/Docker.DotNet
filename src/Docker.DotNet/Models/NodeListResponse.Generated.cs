using System;
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
    public class NodeListResponse // (swarm.Node)
    {
        public NodeListResponse()
        {
        }

        public NodeListResponse(Meta Meta)
        {
            if (Meta != null)
            {
                this.Version = Meta.Version;
                this.CreatedAt = Meta.CreatedAt;
                this.UpdatedAt = Meta.UpdatedAt;
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
        public NodeUpdateParameters Spec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Description")]
#else
        [DataMember(Name = "Description", EmitDefaultValue = false)]
#endif
        public NodeDescription Description { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Status")]
#else
        [DataMember(Name = "Status", EmitDefaultValue = false)]
#endif
        public NodeStatus Status { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ManagerStatus")]
#else
        [DataMember(Name = "ManagerStatus", EmitDefaultValue = false)]
#endif
        public ManagerStatus ManagerStatus { get; set; }
    }
}
