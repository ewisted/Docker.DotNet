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
    public class DeviceRequest // (container.DeviceRequest)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Driver")]
#else
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
#endif
        public string Driver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Count")]
#else
        [DataMember(Name = "Count", EmitDefaultValue = false)]
#endif
        public long Count { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DeviceIDs")]
#else
        [DataMember(Name = "DeviceIDs", EmitDefaultValue = false)]
#endif
        public IList<string> DeviceIDs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Capabilities")]
#else
        [DataMember(Name = "Capabilities", EmitDefaultValue = false)]
#endif
        public IList<IList<string>> Capabilities { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Options")]
#else
        [DataMember(Name = "Options", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Options { get; set; }
    }
}
