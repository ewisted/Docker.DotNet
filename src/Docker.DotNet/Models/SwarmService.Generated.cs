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
    public class SwarmService // (swarm.Service)
    {
        public SwarmService()
        {
        }

        public SwarmService(Meta Meta)
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
        public ServiceSpec Spec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PreviousSpec")]
#else
        [DataMember(Name = "PreviousSpec", EmitDefaultValue = false)]
#endif
        public ServiceSpec PreviousSpec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Endpoint")]
#else
        [DataMember(Name = "Endpoint", EmitDefaultValue = false)]
#endif
        public Endpoint Endpoint { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("UpdateStatus")]
#else
        [DataMember(Name = "UpdateStatus", EmitDefaultValue = false)]
#endif
        public UpdateStatus UpdateStatus { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ServiceStatus")]
#else
        [DataMember(Name = "ServiceStatus", EmitDefaultValue = false)]
#endif
        public ServiceStatus ServiceStatus { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("JobStatus")]
#else
        [DataMember(Name = "JobStatus", EmitDefaultValue = false)]
#endif
        public JobStatus JobStatus { get; set; }
    }
}
