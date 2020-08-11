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
    public class ImagesListResponse // (types.ImageSummary)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Containers")]
#else
        [DataMember(Name = "Containers", EmitDefaultValue = false)]
#endif
        public long Containers { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Created")]
#else
        [DataMember(Name = "Created", EmitDefaultValue = false)]
#endif
        public DateTime Created { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Id")]
#else
        [DataMember(Name = "Id", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ParentId")]
#else
        [DataMember(Name = "ParentId", EmitDefaultValue = false)]
#endif
        public string ParentID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RepoDigests")]
#else
        [DataMember(Name = "RepoDigests", EmitDefaultValue = false)]
#endif
        public IList<string> RepoDigests { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RepoTags")]
#else
        [DataMember(Name = "RepoTags", EmitDefaultValue = false)]
#endif
        public IList<string> RepoTags { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SharedSize")]
#else
        [DataMember(Name = "SharedSize", EmitDefaultValue = false)]
#endif
        public long SharedSize { get; set; }

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
    }
}
