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
    public class ThrottlingData // (types.ThrottlingData)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("periods")]
#else
        [DataMember(Name = "periods", EmitDefaultValue = false)]
#endif
        public ulong Periods { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("throttled_periods")]
#else
        [DataMember(Name = "throttled_periods", EmitDefaultValue = false)]
#endif
        public ulong ThrottledPeriods { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("throttled_time")]
#else
        [DataMember(Name = "throttled_time", EmitDefaultValue = false)]
#endif
        public ulong ThrottledTime { get; set; }
    }
}
