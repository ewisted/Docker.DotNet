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
    public class VolumeResponse // (main.VolumeResponse)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("CreatedAt")]
#else
        [DataMember(Name = "CreatedAt", EmitDefaultValue = false)]
#endif
        public string CreatedAt { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Driver")]
#else
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
#endif
        public string Driver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mountpoint")]
#else
        [DataMember(Name = "Mountpoint", EmitDefaultValue = false)]
#endif
        public string Mountpoint { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Options")]
#else
        [DataMember(Name = "Options", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Options { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Scope")]
#else
        [DataMember(Name = "Scope", EmitDefaultValue = false)]
#endif
        public string Scope { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Status")]
#else
        [DataMember(Name = "Status", EmitDefaultValue = false)]
#endif
        public IDictionary<string, object> Status { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("UsageData")]
#else
        [DataMember(Name = "UsageData", EmitDefaultValue = false)]
#endif
        public VolumeUsageData UsageData { get; set; }
    }
}
