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
    public class JobStatus // (swarm.JobStatus)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("JobIteration")]
#else
        [DataMember(Name = "JobIteration", EmitDefaultValue = false)]
#endif
        public Version JobIteration { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LastExecution")]
#else
        [DataMember(Name = "LastExecution", EmitDefaultValue = false)]
#endif
        public DateTime LastExecution { get; set; }
    }
}
