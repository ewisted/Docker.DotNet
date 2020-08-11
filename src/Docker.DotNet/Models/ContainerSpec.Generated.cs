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
    public class ContainerSpec // (swarm.ContainerSpec)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Image")]
#else
        [DataMember(Name = "Image", EmitDefaultValue = false)]
#endif
        public string Image { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Command")]
#else
        [DataMember(Name = "Command", EmitDefaultValue = false)]
#endif
        public IList<string> Command { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Args")]
#else
        [DataMember(Name = "Args", EmitDefaultValue = false)]
#endif
        public IList<string> Args { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Hostname")]
#else
        [DataMember(Name = "Hostname", EmitDefaultValue = false)]
#endif
        public string Hostname { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Env")]
#else
        [DataMember(Name = "Env", EmitDefaultValue = false)]
#endif
        public IList<string> Env { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Dir")]
#else
        [DataMember(Name = "Dir", EmitDefaultValue = false)]
#endif
        public string Dir { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("User")]
#else
        [DataMember(Name = "User", EmitDefaultValue = false)]
#endif
        public string User { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Groups")]
#else
        [DataMember(Name = "Groups", EmitDefaultValue = false)]
#endif
        public IList<string> Groups { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Privileges")]
#else
        [DataMember(Name = "Privileges", EmitDefaultValue = false)]
#endif
        public Privileges Privileges { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Init")]
#else
        [DataMember(Name = "Init", EmitDefaultValue = false)]
#endif
        public bool? Init { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("StopSignal")]
#else
        [DataMember(Name = "StopSignal", EmitDefaultValue = false)]
#endif
        public string StopSignal { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("TTY")]
#else
        [DataMember(Name = "TTY", EmitDefaultValue = false)]
#endif
        public bool TTY { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OpenStdin")]
#else
        [DataMember(Name = "OpenStdin", EmitDefaultValue = false)]
#endif
        public bool OpenStdin { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ReadOnly")]
#else
        [DataMember(Name = "ReadOnly", EmitDefaultValue = false)]
#endif
        public bool ReadOnly { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mounts")]
#else
        [DataMember(Name = "Mounts", EmitDefaultValue = false)]
#endif
        public IList<Mount> Mounts { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("StopGracePeriod")]
#else
        [DataMember(Name = "StopGracePeriod", EmitDefaultValue = false)]
#endif
        public long? StopGracePeriod { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Healthcheck")]
#else
        [DataMember(Name = "Healthcheck", EmitDefaultValue = false)]
#endif
        public HealthConfig Healthcheck { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Hosts")]
#else
        [DataMember(Name = "Hosts", EmitDefaultValue = false)]
#endif
        public IList<string> Hosts { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DNSConfig")]
#else
        [DataMember(Name = "DNSConfig", EmitDefaultValue = false)]
#endif
        public DNSConfig DNSConfig { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Secrets")]
#else
        [DataMember(Name = "Secrets", EmitDefaultValue = false)]
#endif
        public IList<SecretReference> Secrets { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Configs")]
#else
        [DataMember(Name = "Configs", EmitDefaultValue = false)]
#endif
        public IList<SwarmConfigReference> Configs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Isolation")]
#else
        [DataMember(Name = "Isolation", EmitDefaultValue = false)]
#endif
        public string Isolation { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Sysctls")]
#else
        [DataMember(Name = "Sysctls", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Sysctls { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CapabilityAdd")]
#else
        [DataMember(Name = "CapabilityAdd", EmitDefaultValue = false)]
#endif
        public IList<string> CapabilityAdd { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CapabilityDrop")]
#else
        [DataMember(Name = "CapabilityDrop", EmitDefaultValue = false)]
#endif
        public IList<string> CapabilityDrop { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Ulimits")]
#else
        [DataMember(Name = "Ulimits", EmitDefaultValue = false)]
#endif
        public IList<Ulimit> Ulimits { get; set; }
    }
}
