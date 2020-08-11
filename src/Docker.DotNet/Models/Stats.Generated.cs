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
    public class Stats // (types.Stats)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("read")]
#else
        [DataMember(Name = "read", EmitDefaultValue = false)]
#endif
        public DateTime Read { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("preread")]
#else
        [DataMember(Name = "preread", EmitDefaultValue = false)]
#endif
        public DateTime PreRead { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("pids_stats")]
#else
        [DataMember(Name = "pids_stats", EmitDefaultValue = false)]
#endif
        public PidsStats PidsStats { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("blkio_stats")]
#else
        [DataMember(Name = "blkio_stats", EmitDefaultValue = false)]
#endif
        public BlkioStats BlkioStats { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("num_procs")]
#else
        [DataMember(Name = "num_procs", EmitDefaultValue = false)]
#endif
        public uint NumProcs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("storage_stats")]
#else
        [DataMember(Name = "storage_stats", EmitDefaultValue = false)]
#endif
        public StorageStats StorageStats { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("cpu_stats")]
#else
        [DataMember(Name = "cpu_stats", EmitDefaultValue = false)]
#endif
        public CPUStats CPUStats { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("precpu_stats")]
#else
        [DataMember(Name = "precpu_stats", EmitDefaultValue = false)]
#endif
        public CPUStats PreCPUStats { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("memory_stats")]
#else
        [DataMember(Name = "memory_stats", EmitDefaultValue = false)]
#endif
        public MemoryStats MemoryStats { get; set; }
    }
}
