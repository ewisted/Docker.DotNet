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
    public class DeviceMapping // (container.DeviceMapping)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("PathOnHost")]
#else
        [DataMember(Name = "PathOnHost", EmitDefaultValue = false)]
#endif
        public string PathOnHost { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PathInContainer")]
#else
        [DataMember(Name = "PathInContainer", EmitDefaultValue = false)]
#endif
        public string PathInContainer { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CgroupPermissions")]
#else
        [DataMember(Name = "CgroupPermissions", EmitDefaultValue = false)]
#endif
        public string CgroupPermissions { get; set; }
    }
}
