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
    public class HealthcheckResult // (types.HealthcheckResult)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Start")]
#else
        [DataMember(Name = "Start", EmitDefaultValue = false)]
#endif
        public DateTime Start { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("End")]
#else
        [DataMember(Name = "End", EmitDefaultValue = false)]
#endif
        public DateTime End { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ExitCode")]
#else
        [DataMember(Name = "ExitCode", EmitDefaultValue = false)]
#endif
        public long ExitCode { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Output")]
#else
        [DataMember(Name = "Output", EmitDefaultValue = false)]
#endif
        public string Output { get; set; }
    }
}
