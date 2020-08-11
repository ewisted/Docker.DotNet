using System;
using System.Collections.Generic;
#if !NETSTANDARD2_1
using System.Runtime.Serialization;
#else
using System.Text.Json.Serialization;
#endif
#if !NETSTANDARD2_1
using Newtonsoft.Json;
#else
using System.Text.Json;
#endif

namespace Docker.DotNet.Models
{
#if !NETSTANDARD2_1
    [DataContract]
#endif
    public class HealthConfig // (container.HealthConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Test")]
#else
        [DataMember(Name = "Test", EmitDefaultValue = false)]
#endif
        public IList<string> Test { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Interval")]
#else
        [DataMember(Name = "Interval", EmitDefaultValue = false)]
#endif
        [JsonConverter(typeof(TimeSpanNanosecondsConverter))]
        public TimeSpan Interval { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Timeout")]
#else
        [DataMember(Name = "Timeout", EmitDefaultValue = false)]
#endif
        [JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan Timeout { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("StartPeriod")]
#else
        [DataMember(Name = "StartPeriod", EmitDefaultValue = false)]
#endif
        public long StartPeriod { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Retries")]
#else
        [DataMember(Name = "Retries", EmitDefaultValue = false)]
#endif
        public long Retries { get; set; }
    }
}
