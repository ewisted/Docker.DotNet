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
    public class RootFS // (types.RootFS)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Type")]
#else
        [DataMember(Name = "Type", EmitDefaultValue = false)]
#endif
        public string Type { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Layers")]
#else
        [DataMember(Name = "Layers", EmitDefaultValue = false)]
#endif
        public IList<string> Layers { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BaseLayer")]
#else
        [DataMember(Name = "BaseLayer", EmitDefaultValue = false)]
#endif
        public string BaseLayer { get; set; }
    }
}
