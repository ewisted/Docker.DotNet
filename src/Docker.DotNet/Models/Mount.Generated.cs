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
    public class Mount // (mount.Mount)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Type")]
#else
        [DataMember(Name = "Type", EmitDefaultValue = false)]
#endif
        public string Type { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Source")]
#else
        [DataMember(Name = "Source", EmitDefaultValue = false)]
#endif
        public string Source { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Target")]
#else
        [DataMember(Name = "Target", EmitDefaultValue = false)]
#endif
        public string Target { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ReadOnly")]
#else
        [DataMember(Name = "ReadOnly", EmitDefaultValue = false)]
#endif
        public bool ReadOnly { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Consistency")]
#else
        [DataMember(Name = "Consistency", EmitDefaultValue = false)]
#endif
        public string Consistency { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BindOptions")]
#else
        [DataMember(Name = "BindOptions", EmitDefaultValue = false)]
#endif
        public BindOptions BindOptions { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("VolumeOptions")]
#else
        [DataMember(Name = "VolumeOptions", EmitDefaultValue = false)]
#endif
        public VolumeOptions VolumeOptions { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("TmpfsOptions")]
#else
        [DataMember(Name = "TmpfsOptions", EmitDefaultValue = false)]
#endif
        public TmpfsOptions TmpfsOptions { get; set; }
    }
}
