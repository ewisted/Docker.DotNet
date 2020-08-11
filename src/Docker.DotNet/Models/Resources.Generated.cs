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
    public class Resources // (container.Resources)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("CpuShares")]
#else
        [DataMember(Name = "CpuShares", EmitDefaultValue = false)]
#endif
        public long CPUShares { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Memory")]
#else
        [DataMember(Name = "Memory", EmitDefaultValue = false)]
#endif
        public long Memory { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NanoCpus")]
#else
        [DataMember(Name = "NanoCpus", EmitDefaultValue = false)]
#endif
        public long NanoCPUs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CgroupParent")]
#else
        [DataMember(Name = "CgroupParent", EmitDefaultValue = false)]
#endif
        public string CgroupParent { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BlkioWeight")]
#else
        [DataMember(Name = "BlkioWeight", EmitDefaultValue = false)]
#endif
        public ushort BlkioWeight { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BlkioWeightDevice")]
#else
        [DataMember(Name = "BlkioWeightDevice", EmitDefaultValue = false)]
#endif
        public IList<WeightDevice> BlkioWeightDevice { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BlkioDeviceReadBps")]
#else
        [DataMember(Name = "BlkioDeviceReadBps", EmitDefaultValue = false)]
#endif
        public IList<ThrottleDevice> BlkioDeviceReadBps { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BlkioDeviceWriteBps")]
#else
        [DataMember(Name = "BlkioDeviceWriteBps", EmitDefaultValue = false)]
#endif
        public IList<ThrottleDevice> BlkioDeviceWriteBps { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BlkioDeviceReadIOps")]
#else
        [DataMember(Name = "BlkioDeviceReadIOps", EmitDefaultValue = false)]
#endif
        public IList<ThrottleDevice> BlkioDeviceReadIOps { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BlkioDeviceWriteIOps")]
#else
        [DataMember(Name = "BlkioDeviceWriteIOps", EmitDefaultValue = false)]
#endif
        public IList<ThrottleDevice> BlkioDeviceWriteIOps { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CpuPeriod")]
#else
        [DataMember(Name = "CpuPeriod", EmitDefaultValue = false)]
#endif
        public long CPUPeriod { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CpuQuota")]
#else
        [DataMember(Name = "CpuQuota", EmitDefaultValue = false)]
#endif
        public long CPUQuota { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CpuRealtimePeriod")]
#else
        [DataMember(Name = "CpuRealtimePeriod", EmitDefaultValue = false)]
#endif
        public long CPURealtimePeriod { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CpuRealtimeRuntime")]
#else
        [DataMember(Name = "CpuRealtimeRuntime", EmitDefaultValue = false)]
#endif
        public long CPURealtimeRuntime { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CpusetCpus")]
#else
        [DataMember(Name = "CpusetCpus", EmitDefaultValue = false)]
#endif
        public string CpusetCpus { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CpusetMems")]
#else
        [DataMember(Name = "CpusetMems", EmitDefaultValue = false)]
#endif
        public string CpusetMems { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Devices")]
#else
        [DataMember(Name = "Devices", EmitDefaultValue = false)]
#endif
        public IList<DeviceMapping> Devices { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DeviceCgroupRules")]
#else
        [DataMember(Name = "DeviceCgroupRules", EmitDefaultValue = false)]
#endif
        public IList<string> DeviceCgroupRules { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DeviceRequests")]
#else
        [DataMember(Name = "DeviceRequests", EmitDefaultValue = false)]
#endif
        public IList<DeviceRequest> DeviceRequests { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("KernelMemory")]
#else
        [DataMember(Name = "KernelMemory", EmitDefaultValue = false)]
#endif
        public long KernelMemory { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("KernelMemoryTCP")]
#else
        [DataMember(Name = "KernelMemoryTCP", EmitDefaultValue = false)]
#endif
        public long KernelMemoryTCP { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MemoryReservation")]
#else
        [DataMember(Name = "MemoryReservation", EmitDefaultValue = false)]
#endif
        public long MemoryReservation { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MemorySwap")]
#else
        [DataMember(Name = "MemorySwap", EmitDefaultValue = false)]
#endif
        public long MemorySwap { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MemorySwappiness")]
#else
        [DataMember(Name = "MemorySwappiness", EmitDefaultValue = false)]
#endif
        public long? MemorySwappiness { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OomKillDisable")]
#else
        [DataMember(Name = "OomKillDisable", EmitDefaultValue = false)]
#endif
        public bool? OomKillDisable { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PidsLimit")]
#else
        [DataMember(Name = "PidsLimit", EmitDefaultValue = false)]
#endif
        public long? PidsLimit { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Ulimits")]
#else
        [DataMember(Name = "Ulimits", EmitDefaultValue = false)]
#endif
        public IList<Ulimit> Ulimits { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CpuCount")]
#else
        [DataMember(Name = "CpuCount", EmitDefaultValue = false)]
#endif
        public long CPUCount { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CpuPercent")]
#else
        [DataMember(Name = "CpuPercent", EmitDefaultValue = false)]
#endif
        public long CPUPercent { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IOMaximumIOps")]
#else
        [DataMember(Name = "IOMaximumIOps", EmitDefaultValue = false)]
#endif
        public ulong IOMaximumIOps { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IOMaximumBandwidth")]
#else
        [DataMember(Name = "IOMaximumBandwidth", EmitDefaultValue = false)]
#endif
        public ulong IOMaximumBandwidth { get; set; }
    }
}
