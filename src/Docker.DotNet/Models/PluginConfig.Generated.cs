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
    public class PluginConfig // (types.PluginConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Args")]
#else
        [DataMember(Name = "Args", EmitDefaultValue = false)]
#endif
        public PluginConfigArgs Args { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Description")]
#else
        [DataMember(Name = "Description", EmitDefaultValue = false)]
#endif
        public string Description { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DockerVersion")]
#else
        [DataMember(Name = "DockerVersion", EmitDefaultValue = false)]
#endif
        public string DockerVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Documentation")]
#else
        [DataMember(Name = "Documentation", EmitDefaultValue = false)]
#endif
        public string Documentation { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Entrypoint")]
#else
        [DataMember(Name = "Entrypoint", EmitDefaultValue = false)]
#endif
        public IList<string> Entrypoint { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Env")]
#else
        [DataMember(Name = "Env", EmitDefaultValue = false)]
#endif
        public IList<PluginEnv> Env { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Interface")]
#else
        [DataMember(Name = "Interface", EmitDefaultValue = false)]
#endif
        public PluginConfigInterface Interface { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IpcHost")]
#else
        [DataMember(Name = "IpcHost", EmitDefaultValue = false)]
#endif
        public bool IpcHost { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Linux")]
#else
        [DataMember(Name = "Linux", EmitDefaultValue = false)]
#endif
        public PluginConfigLinux Linux { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mounts")]
#else
        [DataMember(Name = "Mounts", EmitDefaultValue = false)]
#endif
        public IList<PluginMount> Mounts { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Network")]
#else
        [DataMember(Name = "Network", EmitDefaultValue = false)]
#endif
        public PluginConfigNetwork Network { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PidHost")]
#else
        [DataMember(Name = "PidHost", EmitDefaultValue = false)]
#endif
        public bool PidHost { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PropagatedMount")]
#else
        [DataMember(Name = "PropagatedMount", EmitDefaultValue = false)]
#endif
        public string PropagatedMount { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("User")]
#else
        [DataMember(Name = "User", EmitDefaultValue = false)]
#endif
        public PluginConfigUser User { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("WorkDir")]
#else
        [DataMember(Name = "WorkDir", EmitDefaultValue = false)]
#endif
        public string WorkDir { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("rootfs")]
#else
        [DataMember(Name = "rootfs", EmitDefaultValue = false)]
#endif
        public PluginConfigRootfs Rootfs { get; set; }
    }
}
