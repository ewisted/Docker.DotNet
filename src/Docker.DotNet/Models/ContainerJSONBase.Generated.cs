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
    public class ContainerJSONBase // (types.ContainerJSONBase)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Id")]
#else
        [DataMember(Name = "Id", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Created")]
#else
        [DataMember(Name = "Created", EmitDefaultValue = false)]
#endif
        public DateTime Created { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Path")]
#else
        [DataMember(Name = "Path", EmitDefaultValue = false)]
#endif
        public string Path { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Args")]
#else
        [DataMember(Name = "Args", EmitDefaultValue = false)]
#endif
        public IList<string> Args { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("State")]
#else
        [DataMember(Name = "State", EmitDefaultValue = false)]
#endif
        public ContainerState State { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Image")]
#else
        [DataMember(Name = "Image", EmitDefaultValue = false)]
#endif
        public string Image { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ResolvConfPath")]
#else
        [DataMember(Name = "ResolvConfPath", EmitDefaultValue = false)]
#endif
        public string ResolvConfPath { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("HostnamePath")]
#else
        [DataMember(Name = "HostnamePath", EmitDefaultValue = false)]
#endif
        public string HostnamePath { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("HostsPath")]
#else
        [DataMember(Name = "HostsPath", EmitDefaultValue = false)]
#endif
        public string HostsPath { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LogPath")]
#else
        [DataMember(Name = "LogPath", EmitDefaultValue = false)]
#endif
        public string LogPath { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Node")]
#else
        [DataMember(Name = "Node", EmitDefaultValue = false)]
#endif
        public ContainerNode Node { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RestartCount")]
#else
        [DataMember(Name = "RestartCount", EmitDefaultValue = false)]
#endif
        public long RestartCount { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Driver")]
#else
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
#endif
        public string Driver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Platform")]
#else
        [DataMember(Name = "Platform", EmitDefaultValue = false)]
#endif
        public string Platform { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MountLabel")]
#else
        [DataMember(Name = "MountLabel", EmitDefaultValue = false)]
#endif
        public string MountLabel { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ProcessLabel")]
#else
        [DataMember(Name = "ProcessLabel", EmitDefaultValue = false)]
#endif
        public string ProcessLabel { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AppArmorProfile")]
#else
        [DataMember(Name = "AppArmorProfile", EmitDefaultValue = false)]
#endif
        public string AppArmorProfile { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ExecIDs")]
#else
        [DataMember(Name = "ExecIDs", EmitDefaultValue = false)]
#endif
        public IList<string> ExecIDs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("HostConfig")]
#else
        [DataMember(Name = "HostConfig", EmitDefaultValue = false)]
#endif
        public HostConfig HostConfig { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GraphDriver")]
#else
        [DataMember(Name = "GraphDriver", EmitDefaultValue = false)]
#endif
        public GraphDriverData GraphDriver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SizeRw")]
#else
        [DataMember(Name = "SizeRw", EmitDefaultValue = false)]
#endif
        public long? SizeRw { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SizeRootFs")]
#else
        [DataMember(Name = "SizeRootFs", EmitDefaultValue = false)]
#endif
        public long? SizeRootFs { get; set; }
    }
}
