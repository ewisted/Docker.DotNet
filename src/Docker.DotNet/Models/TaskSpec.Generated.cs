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
    public class TaskSpec // (swarm.TaskSpec)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ContainerSpec")]
#else
        [DataMember(Name = "ContainerSpec", EmitDefaultValue = false)]
#endif
        public ContainerSpec ContainerSpec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PluginSpec")]
#else
        [DataMember(Name = "PluginSpec", EmitDefaultValue = false)]
#endif
        public PluginSpec PluginSpec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NetworkAttachmentSpec")]
#else
        [DataMember(Name = "NetworkAttachmentSpec", EmitDefaultValue = false)]
#endif
        public NetworkAttachmentSpec NetworkAttachmentSpec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Resources")]
#else
        [DataMember(Name = "Resources", EmitDefaultValue = false)]
#endif
        public ResourceRequirements Resources { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RestartPolicy")]
#else
        [DataMember(Name = "RestartPolicy", EmitDefaultValue = false)]
#endif
        public SwarmRestartPolicy RestartPolicy { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Placement")]
#else
        [DataMember(Name = "Placement", EmitDefaultValue = false)]
#endif
        public Placement Placement { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Networks")]
#else
        [DataMember(Name = "Networks", EmitDefaultValue = false)]
#endif
        public IList<NetworkAttachmentConfig> Networks { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LogDriver")]
#else
        [DataMember(Name = "LogDriver", EmitDefaultValue = false)]
#endif
        public SwarmDriver LogDriver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ForceUpdate")]
#else
        [DataMember(Name = "ForceUpdate", EmitDefaultValue = false)]
#endif
        public ulong ForceUpdate { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Runtime")]
#else
        [DataMember(Name = "Runtime", EmitDefaultValue = false)]
#endif
        public string Runtime { get; set; }
    }
}
