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
    public class PidsStats // (types.PidsStats)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("current")]
#else
        [DataMember(Name = "current", EmitDefaultValue = false)]
#endif
        public ulong Current { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("limit")]
#else
        [DataMember(Name = "limit", EmitDefaultValue = false)]
#endif
        public ulong Limit { get; set; }
    }
}
