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
    public class Message // (events.Message)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("status")]
#else
        [DataMember(Name = "status", EmitDefaultValue = false)]
#endif
        public string Status { get; set; }

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
        [JsonPropertyName("Type")]
#else
        [DataMember(Name = "Type", EmitDefaultValue = false)]
#endif
        public string Type { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Action")]
#else
        [DataMember(Name = "Action", EmitDefaultValue = false)]
#endif
        public string Action { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Actor")]
#else
        [DataMember(Name = "Actor", EmitDefaultValue = false)]
#endif
        public Actor Actor { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("scope")]
#else
        [DataMember(Name = "scope", EmitDefaultValue = false)]
#endif
        public string Scope { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("time")]
#else
        [DataMember(Name = "time", EmitDefaultValue = false)]
#endif
        public long Time { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("timeNano")]
#else
        [DataMember(Name = "timeNano", EmitDefaultValue = false)]
#endif
        public long TimeNano { get; set; }
    }
}
