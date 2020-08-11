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
    public class ContainerPathStatResponse // (types.ContainerPathStat)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("name")]
#else
        [DataMember(Name = "name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("size")]
#else
        [DataMember(Name = "size", EmitDefaultValue = false)]
#endif
        public long Size { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("mode")]
#else
        [DataMember(Name = "mode", EmitDefaultValue = false)]
#endif
        public uint Mode { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("mtime")]
#else
        [DataMember(Name = "mtime", EmitDefaultValue = false)]
#endif
        public DateTime Mtime { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("linkTarget")]
#else
        [DataMember(Name = "linkTarget", EmitDefaultValue = false)]
#endif
        public string LinkTarget { get; set; }
    }
}
