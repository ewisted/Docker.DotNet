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
    public class SystemInfoResponse // (types.Info)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ID")]
#else
        [DataMember(Name = "ID", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Containers")]
#else
        [DataMember(Name = "Containers", EmitDefaultValue = false)]
#endif
        public long Containers { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ContainersRunning")]
#else
        [DataMember(Name = "ContainersRunning", EmitDefaultValue = false)]
#endif
        public long ContainersRunning { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ContainersPaused")]
#else
        [DataMember(Name = "ContainersPaused", EmitDefaultValue = false)]
#endif
        public long ContainersPaused { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ContainersStopped")]
#else
        [DataMember(Name = "ContainersStopped", EmitDefaultValue = false)]
#endif
        public long ContainersStopped { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Images")]
#else
        [DataMember(Name = "Images", EmitDefaultValue = false)]
#endif
        public long Images { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Driver")]
#else
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
#endif
        public string Driver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DriverStatus")]
#else
        [DataMember(Name = "DriverStatus", EmitDefaultValue = false)]
#endif
        public IList<string[]> DriverStatus { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SystemStatus")]
#else
        [DataMember(Name = "SystemStatus", EmitDefaultValue = false)]
#endif
        public IList<string[]> SystemStatus { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Plugins")]
#else
        [DataMember(Name = "Plugins", EmitDefaultValue = false)]
#endif
        public PluginsInfo Plugins { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MemoryLimit")]
#else
        [DataMember(Name = "MemoryLimit", EmitDefaultValue = false)]
#endif
        public bool MemoryLimit { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SwapLimit")]
#else
        [DataMember(Name = "SwapLimit", EmitDefaultValue = false)]
#endif
        public bool SwapLimit { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("KernelMemory")]
#else
        [DataMember(Name = "KernelMemory", EmitDefaultValue = false)]
#endif
        public bool KernelMemory { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("KernelMemoryTCP")]
#else
        [DataMember(Name = "KernelMemoryTCP", EmitDefaultValue = false)]
#endif
        public bool KernelMemoryTCP { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CpuCfsPeriod")]
#else
        [DataMember(Name = "CpuCfsPeriod", EmitDefaultValue = false)]
#endif
        public bool CPUCfsPeriod { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CpuCfsQuota")]
#else
        [DataMember(Name = "CpuCfsQuota", EmitDefaultValue = false)]
#endif
        public bool CPUCfsQuota { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CPUShares")]
#else
        [DataMember(Name = "CPUShares", EmitDefaultValue = false)]
#endif
        public bool CPUShares { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CPUSet")]
#else
        [DataMember(Name = "CPUSet", EmitDefaultValue = false)]
#endif
        public bool CPUSet { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PidsLimit")]
#else
        [DataMember(Name = "PidsLimit", EmitDefaultValue = false)]
#endif
        public bool PidsLimit { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPv4Forwarding")]
#else
        [DataMember(Name = "IPv4Forwarding", EmitDefaultValue = false)]
#endif
        public bool IPv4Forwarding { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BridgeNfIptables")]
#else
        [DataMember(Name = "BridgeNfIptables", EmitDefaultValue = false)]
#endif
        public bool BridgeNfIptables { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BridgeNfIp6tables")]
#else
        [DataMember(Name = "BridgeNfIp6tables", EmitDefaultValue = false)]
#endif
        public bool BridgeNfIP6tables { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Debug")]
#else
        [DataMember(Name = "Debug", EmitDefaultValue = false)]
#endif
        public bool Debug { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NFd")]
#else
        [DataMember(Name = "NFd", EmitDefaultValue = false)]
#endif
        public long NFd { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OomKillDisable")]
#else
        [DataMember(Name = "OomKillDisable", EmitDefaultValue = false)]
#endif
        public bool OomKillDisable { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NGoroutines")]
#else
        [DataMember(Name = "NGoroutines", EmitDefaultValue = false)]
#endif
        public long NGoroutines { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SystemTime")]
#else
        [DataMember(Name = "SystemTime", EmitDefaultValue = false)]
#endif
        public string SystemTime { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LoggingDriver")]
#else
        [DataMember(Name = "LoggingDriver", EmitDefaultValue = false)]
#endif
        public string LoggingDriver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CgroupDriver")]
#else
        [DataMember(Name = "CgroupDriver", EmitDefaultValue = false)]
#endif
        public string CgroupDriver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CgroupVersion")]
#else
        [DataMember(Name = "CgroupVersion", EmitDefaultValue = false)]
#endif
        public string CgroupVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NEventsListener")]
#else
        [DataMember(Name = "NEventsListener", EmitDefaultValue = false)]
#endif
        public long NEventsListener { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("KernelVersion")]
#else
        [DataMember(Name = "KernelVersion", EmitDefaultValue = false)]
#endif
        public string KernelVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OperatingSystem")]
#else
        [DataMember(Name = "OperatingSystem", EmitDefaultValue = false)]
#endif
        public string OperatingSystem { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OSVersion")]
#else
        [DataMember(Name = "OSVersion", EmitDefaultValue = false)]
#endif
        public string OSVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OSType")]
#else
        [DataMember(Name = "OSType", EmitDefaultValue = false)]
#endif
        public string OSType { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Architecture")]
#else
        [DataMember(Name = "Architecture", EmitDefaultValue = false)]
#endif
        public string Architecture { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IndexServerAddress")]
#else
        [DataMember(Name = "IndexServerAddress", EmitDefaultValue = false)]
#endif
        public string IndexServerAddress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RegistryConfig")]
#else
        [DataMember(Name = "RegistryConfig", EmitDefaultValue = false)]
#endif
        public ServiceConfig RegistryConfig { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NCPU")]
#else
        [DataMember(Name = "NCPU", EmitDefaultValue = false)]
#endif
        public long NCPU { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MemTotal")]
#else
        [DataMember(Name = "MemTotal", EmitDefaultValue = false)]
#endif
        public long MemTotal { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GenericResources")]
#else
        [DataMember(Name = "GenericResources", EmitDefaultValue = false)]
#endif
        public IList<GenericResource> GenericResources { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DockerRootDir")]
#else
        [DataMember(Name = "DockerRootDir", EmitDefaultValue = false)]
#endif
        public string DockerRootDir { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("HttpProxy")]
#else
        [DataMember(Name = "HttpProxy", EmitDefaultValue = false)]
#endif
        public string HTTPProxy { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("HttpsProxy")]
#else
        [DataMember(Name = "HttpsProxy", EmitDefaultValue = false)]
#endif
        public string HTTPSProxy { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NoProxy")]
#else
        [DataMember(Name = "NoProxy", EmitDefaultValue = false)]
#endif
        public string NoProxy { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IList<string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ExperimentalBuild")]
#else
        [DataMember(Name = "ExperimentalBuild", EmitDefaultValue = false)]
#endif
        public bool ExperimentalBuild { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ServerVersion")]
#else
        [DataMember(Name = "ServerVersion", EmitDefaultValue = false)]
#endif
        public string ServerVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ClusterStore")]
#else
        [DataMember(Name = "ClusterStore", EmitDefaultValue = false)]
#endif
        public string ClusterStore { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ClusterAdvertise")]
#else
        [DataMember(Name = "ClusterAdvertise", EmitDefaultValue = false)]
#endif
        public string ClusterAdvertise { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Runtimes")]
#else
        [DataMember(Name = "Runtimes", EmitDefaultValue = false)]
#endif
        public IDictionary<string, Runtime> Runtimes { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DefaultRuntime")]
#else
        [DataMember(Name = "DefaultRuntime", EmitDefaultValue = false)]
#endif
        public string DefaultRuntime { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Swarm")]
#else
        [DataMember(Name = "Swarm", EmitDefaultValue = false)]
#endif
        public Info Swarm { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LiveRestoreEnabled")]
#else
        [DataMember(Name = "LiveRestoreEnabled", EmitDefaultValue = false)]
#endif
        public bool LiveRestoreEnabled { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Isolation")]
#else
        [DataMember(Name = "Isolation", EmitDefaultValue = false)]
#endif
        public string Isolation { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("InitBinary")]
#else
        [DataMember(Name = "InitBinary", EmitDefaultValue = false)]
#endif
        public string InitBinary { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ContainerdCommit")]
#else
        [DataMember(Name = "ContainerdCommit", EmitDefaultValue = false)]
#endif
        public Commit ContainerdCommit { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RuncCommit")]
#else
        [DataMember(Name = "RuncCommit", EmitDefaultValue = false)]
#endif
        public Commit RuncCommit { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("InitCommit")]
#else
        [DataMember(Name = "InitCommit", EmitDefaultValue = false)]
#endif
        public Commit InitCommit { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SecurityOptions")]
#else
        [DataMember(Name = "SecurityOptions", EmitDefaultValue = false)]
#endif
        public IList<string> SecurityOptions { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ProductLicense")]
#else
        [DataMember(Name = "ProductLicense", EmitDefaultValue = false)]
#endif
        public string ProductLicense { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DefaultAddressPools")]
#else
        [DataMember(Name = "DefaultAddressPools", EmitDefaultValue = false)]
#endif
        public IList<NetworkAddressPool> DefaultAddressPools { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Warnings")]
#else
        [DataMember(Name = "Warnings", EmitDefaultValue = false)]
#endif
        public IList<string> Warnings { get; set; }
    }
}
