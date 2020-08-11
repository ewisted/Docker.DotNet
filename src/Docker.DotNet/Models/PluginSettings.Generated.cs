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
    public class PluginSettings // (types.PluginSettings)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Args")]
#else
        [DataMember(Name = "Args", EmitDefaultValue = false)]
#endif
        public IList<string> Args { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Devices")]
#else
        [DataMember(Name = "Devices", EmitDefaultValue = false)]
#endif
        public IList<PluginDevice> Devices { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Env")]
#else
        [DataMember(Name = "Env", EmitDefaultValue = false)]
#endif
        public IList<string> Env { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mounts")]
#else
        [DataMember(Name = "Mounts", EmitDefaultValue = false)]
#endif
        public IList<PluginMount> Mounts { get; set; }
    }
}
