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
    public class MemoryStats // (types.MemoryStats)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("usage")]
#else
        [DataMember(Name = "usage", EmitDefaultValue = false)]
#endif
        public ulong Usage { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("max_usage")]
#else
        [DataMember(Name = "max_usage", EmitDefaultValue = false)]
#endif
        public ulong MaxUsage { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("stats")]
#else
        [DataMember(Name = "stats", EmitDefaultValue = false)]
#endif
        public IDictionary<string, ulong> Stats { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("failcnt")]
#else
        [DataMember(Name = "failcnt", EmitDefaultValue = false)]
#endif
        public ulong Failcnt { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("limit")]
#else
        [DataMember(Name = "limit", EmitDefaultValue = false)]
#endif
        public ulong Limit { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("commitbytes")]
#else
        [DataMember(Name = "commitbytes", EmitDefaultValue = false)]
#endif
        public ulong Commit { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("commitpeakbytes")]
#else
        [DataMember(Name = "commitpeakbytes", EmitDefaultValue = false)]
#endif
        public ulong CommitPeak { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("privateworkingset")]
#else
        [DataMember(Name = "privateworkingset", EmitDefaultValue = false)]
#endif
        public ulong PrivateWorkingSet { get; set; }
    }
}
