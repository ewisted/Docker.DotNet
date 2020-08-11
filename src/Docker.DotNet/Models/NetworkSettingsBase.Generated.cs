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
    public class NetworkSettingsBase // (types.NetworkSettingsBase)
    {
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
    }
}
