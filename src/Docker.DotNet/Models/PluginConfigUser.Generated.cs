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
    public class PluginConfigUser // (types.PluginConfigUser)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("GID")]
#else
        [DataMember(Name = "GID", EmitDefaultValue = false)]
#endif
        public uint GID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("UID")]
#else
        [DataMember(Name = "UID", EmitDefaultValue = false)]
#endif
        public uint UID { get; set; }
    }
}
