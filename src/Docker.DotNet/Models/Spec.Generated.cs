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
    public class Spec // (swarm.Spec)
    {
        public Spec()
        {
        }

        public Spec(Annotations Annotations)
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
        [JsonPropertyName("Orchestration")]
#else
        [DataMember(Name = "Orchestration", EmitDefaultValue = false)]
#endif
        public OrchestrationConfig Orchestration { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Raft")]
#else
        [DataMember(Name = "Raft", EmitDefaultValue = false)]
#endif
        public RaftConfig Raft { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Dispatcher")]
#else
        [DataMember(Name = "Dispatcher", EmitDefaultValue = false)]
#endif
        public DispatcherConfig Dispatcher { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CAConfig")]
#else
        [DataMember(Name = "CAConfig", EmitDefaultValue = false)]
#endif
        public CAConfig CAConfig { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("TaskDefaults")]
#else
        [DataMember(Name = "TaskDefaults", EmitDefaultValue = false)]
#endif
        public TaskDefaults TaskDefaults { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("EncryptionConfig")]
#else
        [DataMember(Name = "EncryptionConfig", EmitDefaultValue = false)]
#endif
        public EncryptionConfig EncryptionConfig { get; set; }
    }
}
