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
    public class PluginsInfo // (types.PluginsInfo)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Volume")]
#else
        [DataMember(Name = "Volume", EmitDefaultValue = false)]
#endif
        public IList<string> Volume { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Network")]
#else
        [DataMember(Name = "Network", EmitDefaultValue = false)]
#endif
        public IList<string> Network { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Authorization")]
#else
        [DataMember(Name = "Authorization", EmitDefaultValue = false)]
#endif
        public IList<string> Authorization { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Log")]
#else
        [DataMember(Name = "Log", EmitDefaultValue = false)]
#endif
        public IList<string> Log { get; set; }
    }
}
