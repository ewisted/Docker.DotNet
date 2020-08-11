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
    public class JSONError // (jsonmessage.JSONError)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("code")]
#else
        [DataMember(Name = "code", EmitDefaultValue = false)]
#endif
        public long Code { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("message")]
#else
        [DataMember(Name = "message", EmitDefaultValue = false)]
#endif
        public string Message { get; set; }
    }
}
