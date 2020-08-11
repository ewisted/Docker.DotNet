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
    public class ContainerFileSystemChangeResponse // (container.ContainerChangeResponseItem)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Kind")]
#else
        [DataMember(Name = "Kind", EmitDefaultValue = false)]
#endif
        public FileSystemChangeKind Kind { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Path")]
#else
        [DataMember(Name = "Path", EmitDefaultValue = false)]
#endif
        public string Path { get; set; }
    }
}
