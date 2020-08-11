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
    public class SwarmInitParameters // (swarm.InitRequest)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ListenAddr")]
#else
        [DataMember(Name = "ListenAddr", EmitDefaultValue = false)]
#endif
        public string ListenAddr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AdvertiseAddr")]
#else
        [DataMember(Name = "AdvertiseAddr", EmitDefaultValue = false)]
#endif
        public string AdvertiseAddr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DataPathAddr")]
#else
        [DataMember(Name = "DataPathAddr", EmitDefaultValue = false)]
#endif
        public string DataPathAddr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DataPathPort")]
#else
        [DataMember(Name = "DataPathPort", EmitDefaultValue = false)]
#endif
        public uint DataPathPort { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ForceNewCluster")]
#else
        [DataMember(Name = "ForceNewCluster", EmitDefaultValue = false)]
#endif
        public bool ForceNewCluster { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Spec")]
#else
        [DataMember(Name = "Spec", EmitDefaultValue = false)]
#endif
        public Spec Spec { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AutoLockManagers")]
#else
        [DataMember(Name = "AutoLockManagers", EmitDefaultValue = false)]
#endif
        public bool AutoLockManagers { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Availability")]
#else
        [DataMember(Name = "Availability", EmitDefaultValue = false)]
#endif
        public string Availability { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DefaultAddrPool")]
#else
        [DataMember(Name = "DefaultAddrPool", EmitDefaultValue = false)]
#endif
        public IList<string> DefaultAddrPool { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SubnetSize")]
#else
        [DataMember(Name = "SubnetSize", EmitDefaultValue = false)]
#endif
        public uint SubnetSize { get; set; }
    }
}
