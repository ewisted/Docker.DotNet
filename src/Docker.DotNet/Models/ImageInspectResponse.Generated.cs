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
    public class ImageInspectResponse // (types.ImageInspect)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Id")]
#else
        [DataMember(Name = "Id", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RepoTags")]
#else
        [DataMember(Name = "RepoTags", EmitDefaultValue = false)]
#endif
        public IList<string> RepoTags { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RepoDigests")]
#else
        [DataMember(Name = "RepoDigests", EmitDefaultValue = false)]
#endif
        public IList<string> RepoDigests { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Parent")]
#else
        [DataMember(Name = "Parent", EmitDefaultValue = false)]
#endif
        public string Parent { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Comment")]
#else
        [DataMember(Name = "Comment", EmitDefaultValue = false)]
#endif
        public string Comment { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Created")]
#else
        [DataMember(Name = "Created", EmitDefaultValue = false)]
#endif
        public DateTime Created { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Container")]
#else
        [DataMember(Name = "Container", EmitDefaultValue = false)]
#endif
        public string Container { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ContainerConfig")]
#else
        [DataMember(Name = "ContainerConfig", EmitDefaultValue = false)]
#endif
        public Config ContainerConfig { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DockerVersion")]
#else
        [DataMember(Name = "DockerVersion", EmitDefaultValue = false)]
#endif
        public string DockerVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Author")]
#else
        [DataMember(Name = "Author", EmitDefaultValue = false)]
#endif
        public string Author { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Config")]
#else
        [DataMember(Name = "Config", EmitDefaultValue = false)]
#endif
        public Config Config { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Architecture")]
#else
        [DataMember(Name = "Architecture", EmitDefaultValue = false)]
#endif
        public string Architecture { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Variant")]
#else
        [DataMember(Name = "Variant", EmitDefaultValue = false)]
#endif
        public string Variant { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Os")]
#else
        [DataMember(Name = "Os", EmitDefaultValue = false)]
#endif
        public string Os { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OsVersion")]
#else
        [DataMember(Name = "OsVersion", EmitDefaultValue = false)]
#endif
        public string OsVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Size")]
#else
        [DataMember(Name = "Size", EmitDefaultValue = false)]
#endif
        public long Size { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("VirtualSize")]
#else
        [DataMember(Name = "VirtualSize", EmitDefaultValue = false)]
#endif
        public long VirtualSize { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GraphDriver")]
#else
        [DataMember(Name = "GraphDriver", EmitDefaultValue = false)]
#endif
        public GraphDriverData GraphDriver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RootFS")]
#else
        [DataMember(Name = "RootFS", EmitDefaultValue = false)]
#endif
        public RootFS RootFS { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Metadata")]
#else
        [DataMember(Name = "Metadata", EmitDefaultValue = false)]
#endif
        public ImageMetadata Metadata { get; set; }
    }
}
