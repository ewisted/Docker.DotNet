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
    public class MountPoint // (types.MountPoint)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Type")]
#else
        [DataMember(Name = "Type", EmitDefaultValue = false)]
#endif
        public string Type { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Source")]
#else
        [DataMember(Name = "Source", EmitDefaultValue = false)]
#endif
        public string Source { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Destination")]
#else
        [DataMember(Name = "Destination", EmitDefaultValue = false)]
#endif
        public string Destination { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Driver")]
#else
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
#endif
        public string Driver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mode")]
#else
        [DataMember(Name = "Mode", EmitDefaultValue = false)]
#endif
        public string Mode { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RW")]
#else
        [DataMember(Name = "RW", EmitDefaultValue = false)]
#endif
        public bool RW { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Propagation")]
#else
        [DataMember(Name = "Propagation", EmitDefaultValue = false)]
#endif
        public string Propagation { get; set; }
    }
}
