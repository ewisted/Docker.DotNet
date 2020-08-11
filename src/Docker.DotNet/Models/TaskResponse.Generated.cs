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
    public class TaskResponse // (swarm.Task)
    {
        public TaskResponse()
        {
        }

        public TaskResponse(Meta Meta, Annotations Annotations)
        {
            if (Meta != null)
            {
                this.Version = Meta.Version;
                this.CreatedAt = Meta.CreatedAt;
                this.UpdatedAt = Meta.UpdatedAt;
            }

            if (Annotations != null)
            {
                this.Name = Annotations.Name;
                this.Labels = Annotations.Labels;
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
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Spec")]
#else
        [DataMember(Name = "Spec", EmitDefaultValue = false)]
#endif
        public TaskSpec Spec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ServiceID")]
#else
        [DataMember(Name = "ServiceID", EmitDefaultValue = false)]
#endif
        public string ServiceID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Slot")]
#else
        [DataMember(Name = "Slot", EmitDefaultValue = false)]
#endif
        public long Slot { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NodeID")]
#else
        [DataMember(Name = "NodeID", EmitDefaultValue = false)]
#endif
        public string NodeID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Status")]
#else
        [DataMember(Name = "Status", EmitDefaultValue = false)]
#endif
        public TaskStatus Status { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DesiredState")]
#else
        [DataMember(Name = "DesiredState", EmitDefaultValue = false)]
#endif
        public TaskState DesiredState { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NetworksAttachments")]
#else
        [DataMember(Name = "NetworksAttachments", EmitDefaultValue = false)]
#endif
        public IList<NetworkAttachment> NetworksAttachments { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GenericResources")]
#else
        [DataMember(Name = "GenericResources", EmitDefaultValue = false)]
#endif
        public IList<GenericResource> GenericResources { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("JobIteration")]
#else
        [DataMember(Name = "JobIteration", EmitDefaultValue = false)]
#endif
        public Version JobIteration { get; set; }
    }
}
