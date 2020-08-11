using System;
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
    public class ContainerStatsResponse // (types.StatsJSON)
    {
        public ContainerStatsResponse()
        {
        }

        public ContainerStatsResponse(Stats Stats)
        {
            if (Stats != null)
            {
                this.Read = Stats.Read;
                this.PreRead = Stats.PreRead;
                this.PidsStats = Stats.PidsStats;
                this.BlkioStats = Stats.BlkioStats;
                this.NumProcs = Stats.NumProcs;
                this.StorageStats = Stats.StorageStats;
                this.CPUStats = Stats.CPUStats;
                this.PreCPUStats = Stats.PreCPUStats;
                this.MemoryStats = Stats.MemoryStats;
            }
        }

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

#if NETSTANDARD2_1
        [JsonPropertyName("name")]
#else
        [DataMember(Name = "name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("id")]
#else
        [DataMember(Name = "id", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("networks")]
#else
        [DataMember(Name = "networks", EmitDefaultValue = false)]
#endif
        public IDictionary<string, NetworkStats> Networks { get; set; }
    }
}
