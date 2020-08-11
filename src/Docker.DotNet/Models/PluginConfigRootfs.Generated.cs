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
    public class PluginConfigRootfs // (types.PluginConfigRootfs)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("diff_ids")]
#else
        [DataMember(Name = "diff_ids", EmitDefaultValue = false)]
#endif
        public IList<string> DiffIds { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("type")]
#else
        [DataMember(Name = "type", EmitDefaultValue = false)]
#endif
        public string Type { get; set; }
    }
}
