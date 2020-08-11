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
    public class ServiceSpec // (swarm.ServiceSpec)
    {
        public ServiceSpec()
        {
        }

        public ServiceSpec(Annotations Annotations)
        {
            if (Annotations != null)
            {
                this.Name = Annotations.Name;
                this.Labels = Annotations.Labels;
            }
        }

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
        [JsonPropertyName("TaskTemplate")]
#else
        [DataMember(Name = "TaskTemplate", EmitDefaultValue = false)]
#endif
        public TaskSpec TaskTemplate { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mode")]
#else
        [DataMember(Name = "Mode", EmitDefaultValue = false)]
#endif
        public ServiceMode Mode { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("UpdateConfig")]
#else
        [DataMember(Name = "UpdateConfig", EmitDefaultValue = false)]
#endif
        public SwarmUpdateConfig UpdateConfig { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RollbackConfig")]
#else
        [DataMember(Name = "RollbackConfig", EmitDefaultValue = false)]
#endif
        public SwarmUpdateConfig RollbackConfig { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Networks")]
#else
        [DataMember(Name = "Networks", EmitDefaultValue = false)]
#endif
        public IList<NetworkAttachmentConfig> Networks { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("EndpointSpec")]
#else
        [DataMember(Name = "EndpointSpec", EmitDefaultValue = false)]
#endif
        public EndpointSpec EndpointSpec { get; set; }
    }
}
