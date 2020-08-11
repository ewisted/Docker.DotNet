using System;
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
    public class JSONMessage // (jsonmessage.JSONMessage)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("stream")]
#else
        [DataMember(Name = "stream", EmitDefaultValue = false)]
#endif
        public string Stream { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("status")]
#else
        [DataMember(Name = "status", EmitDefaultValue = false)]
#endif
        public string Status { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("progressDetail")]
#else
        [DataMember(Name = "progressDetail", EmitDefaultValue = false)]
#endif
        public JSONProgress Progress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("progress")]
#else
        [DataMember(Name = "progress", EmitDefaultValue = false)]
#endif
        public string ProgressMessage { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("id")]
#else
        [DataMember(Name = "id", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("from")]
#else
        [DataMember(Name = "from", EmitDefaultValue = false)]
#endif
        public string From { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("time")]
#else
        [DataMember(Name = "time", EmitDefaultValue = false)]
#endif
        public DateTime Time { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("timeNano")]
#else
        [DataMember(Name = "timeNano", EmitDefaultValue = false)]
#endif
        public long TimeNano { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("errorDetail")]
#else
        [DataMember(Name = "errorDetail", EmitDefaultValue = false)]
#endif
        public JSONError Error { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("error")]
#else
        [DataMember(Name = "error", EmitDefaultValue = false)]
#endif
        public string ErrorMessage { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("aux")]
#else
        [DataMember(Name = "aux", EmitDefaultValue = false)]
#endif
        public ObjectExtensionData Aux { get; set; }
    }
}
