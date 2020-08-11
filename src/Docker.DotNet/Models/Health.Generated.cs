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
    public class Health // (types.Health)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Status")]
#else
        [DataMember(Name = "Status", EmitDefaultValue = false)]
#endif
        public string Status { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("FailingStreak")]
#else
        [DataMember(Name = "FailingStreak", EmitDefaultValue = false)]
#endif
        public long FailingStreak { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Log")]
#else
        [DataMember(Name = "Log", EmitDefaultValue = false)]
#endif
        public IList<HealthcheckResult> Log { get; set; }
    }
}
