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
    public class NetworkSettings // (types.NetworkSettings)
    {
        public NetworkSettings()
        {
        }

        public NetworkSettings(NetworkSettingsBase NetworkSettingsBase, DefaultNetworkSettings DefaultNetworkSettings)
        {
            if (NetworkSettingsBase != null)
            {
                this.Bridge = NetworkSettingsBase.Bridge;
                this.SandboxID = NetworkSettingsBase.SandboxID;
                this.HairpinMode = NetworkSettingsBase.HairpinMode;
                this.LinkLocalIPv6Address = NetworkSettingsBase.LinkLocalIPv6Address;
                this.LinkLocalIPv6PrefixLen = NetworkSettingsBase.LinkLocalIPv6PrefixLen;
                this.Ports = NetworkSettingsBase.Ports;
                this.SandboxKey = NetworkSettingsBase.SandboxKey;
                this.SecondaryIPAddresses = NetworkSettingsBase.SecondaryIPAddresses;
                this.SecondaryIPv6Addresses = NetworkSettingsBase.SecondaryIPv6Addresses;
            }

            if (DefaultNetworkSettings != null)
            {
                this.EndpointID = DefaultNetworkSettings.EndpointID;
                this.Gateway = DefaultNetworkSettings.Gateway;
                this.GlobalIPv6Address = DefaultNetworkSettings.GlobalIPv6Address;
                this.GlobalIPv6PrefixLen = DefaultNetworkSettings.GlobalIPv6PrefixLen;
                this.IPAddress = DefaultNetworkSettings.IPAddress;
                this.IPPrefixLen = DefaultNetworkSettings.IPPrefixLen;
                this.IPv6Gateway = DefaultNetworkSettings.IPv6Gateway;
                this.MacAddress = DefaultNetworkSettings.MacAddress;
            }
        }

#if NETSTANDARD2_1
        [JsonPropertyName("Bridge")]
#else
        [DataMember(Name = "Bridge", EmitDefaultValue = false)]
#endif
        public string Bridge { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SandboxID")]
#else
        [DataMember(Name = "SandboxID", EmitDefaultValue = false)]
#endif
        public string SandboxID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("HairpinMode")]
#else
        [DataMember(Name = "HairpinMode", EmitDefaultValue = false)]
#endif
        public bool HairpinMode { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LinkLocalIPv6Address")]
#else
        [DataMember(Name = "LinkLocalIPv6Address", EmitDefaultValue = false)]
#endif
        public string LinkLocalIPv6Address { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LinkLocalIPv6PrefixLen")]
#else
        [DataMember(Name = "LinkLocalIPv6PrefixLen", EmitDefaultValue = false)]
#endif
        public long LinkLocalIPv6PrefixLen { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Ports")]
#else
        [DataMember(Name = "Ports", EmitDefaultValue = false)]
#endif
        public IDictionary<string, IList<PortBinding>> Ports { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SandboxKey")]
#else
        [DataMember(Name = "SandboxKey", EmitDefaultValue = false)]
#endif
        public string SandboxKey { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SecondaryIPAddresses")]
#else
        [DataMember(Name = "SecondaryIPAddresses", EmitDefaultValue = false)]
#endif
        public IList<Address> SecondaryIPAddresses { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SecondaryIPv6Addresses")]
#else
        [DataMember(Name = "SecondaryIPv6Addresses", EmitDefaultValue = false)]
#endif
        public IList<Address> SecondaryIPv6Addresses { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("EndpointID")]
#else
        [DataMember(Name = "EndpointID", EmitDefaultValue = false)]
#endif
        public string EndpointID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Gateway")]
#else
        [DataMember(Name = "Gateway", EmitDefaultValue = false)]
#endif
        public string Gateway { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GlobalIPv6Address")]
#else
        [DataMember(Name = "GlobalIPv6Address", EmitDefaultValue = false)]
#endif
        public string GlobalIPv6Address { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GlobalIPv6PrefixLen")]
#else
        [DataMember(Name = "GlobalIPv6PrefixLen", EmitDefaultValue = false)]
#endif
        public long GlobalIPv6PrefixLen { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPAddress")]
#else
        [DataMember(Name = "IPAddress", EmitDefaultValue = false)]
#endif
        public string IPAddress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPPrefixLen")]
#else
        [DataMember(Name = "IPPrefixLen", EmitDefaultValue = false)]
#endif
        public long IPPrefixLen { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPv6Gateway")]
#else
        [DataMember(Name = "IPv6Gateway", EmitDefaultValue = false)]
#endif
        public string IPv6Gateway { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MacAddress")]
#else
        [DataMember(Name = "MacAddress", EmitDefaultValue = false)]
#endif
        public string MacAddress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Networks")]
#else
        [DataMember(Name = "Networks", EmitDefaultValue = false)]
#endif
        public IDictionary<string, EndpointSettings> Networks { get; set; }
    }
}
