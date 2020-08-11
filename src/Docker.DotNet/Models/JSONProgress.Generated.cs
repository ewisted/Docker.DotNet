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
    public class JSONProgress // (jsonmessage.JSONProgress)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("current")]
#else
        [DataMember(Name = "current", EmitDefaultValue = false)]
#endif
        public long Current { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("total")]
#else
        [DataMember(Name = "total", EmitDefaultValue = false)]
#endif
        public long Total { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("start")]
#else
        [DataMember(Name = "start", EmitDefaultValue = false)]
#endif
        public long Start { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("hidecounts")]
#else
        [DataMember(Name = "hidecounts", EmitDefaultValue = false)]
#endif
        public bool HideCounts { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("units")]
#else
        [DataMember(Name = "units", EmitDefaultValue = false)]
#endif
        public string Units { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("winSize")]
#else
        [DataMember(Name = "winSize", EmitDefaultValue = false)]
#endif
        public long winSize { get; set; }
    }
}
