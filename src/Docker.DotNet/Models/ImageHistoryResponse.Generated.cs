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
    public class ImageHistoryResponse // (image.HistoryResponseItem)
    {
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
        [JsonPropertyName("CreatedBy")]
#else
        [DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
#endif
        public string CreatedBy { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Id")]
#else
        [DataMember(Name = "Id", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Size")]
#else
        [DataMember(Name = "Size", EmitDefaultValue = false)]
#endif
        public long Size { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Tags")]
#else
        [DataMember(Name = "Tags", EmitDefaultValue = false)]
#endif
        public IList<string> Tags { get; set; }
    }
}
