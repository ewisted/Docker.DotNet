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
    public class PluginConfigLinux // (types.PluginConfigLinux)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("AllowAllDevices")]
#else
        [DataMember(Name = "AllowAllDevices", EmitDefaultValue = false)]
#endif
        public bool AllowAllDevices { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Capabilities")]
#else
        [DataMember(Name = "Capabilities", EmitDefaultValue = false)]
#endif
        public IList<string> Capabilities { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Devices")]
#else
        [DataMember(Name = "Devices", EmitDefaultValue = false)]
#endif
        public IList<PluginDevice> Devices { get; set; }
    }
}
