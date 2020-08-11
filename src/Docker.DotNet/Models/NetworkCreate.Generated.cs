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
    public class NetworkCreate // (types.NetworkCreate)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("CheckDuplicate")]
#else
        [DataMember(Name = "CheckDuplicate", EmitDefaultValue = false)]
#endif
        public bool CheckDuplicate { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Driver")]
#else
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
#endif
        public string Driver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Scope")]
#else
        [DataMember(Name = "Scope", EmitDefaultValue = false)]
#endif
        public string Scope { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("EnableIPv6")]
#else
        [DataMember(Name = "EnableIPv6", EmitDefaultValue = false)]
#endif
        public bool EnableIPv6 { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPAM")]
#else
        [DataMember(Name = "IPAM", EmitDefaultValue = false)]
#endif
        public IPAM IPAM { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Internal")]
#else
        [DataMember(Name = "Internal", EmitDefaultValue = false)]
#endif
        public bool Internal { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Attachable")]
#else
        [DataMember(Name = "Attachable", EmitDefaultValue = false)]
#endif
        public bool Attachable { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Ingress")]
#else
        [DataMember(Name = "Ingress", EmitDefaultValue = false)]
#endif
        public bool Ingress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ConfigOnly")]
#else
        [DataMember(Name = "ConfigOnly", EmitDefaultValue = false)]
#endif
        public bool ConfigOnly { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ConfigFrom")]
#else
        [DataMember(Name = "ConfigFrom", EmitDefaultValue = false)]
#endif
        public ConfigReference ConfigFrom { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Options")]
#else
        [DataMember(Name = "Options", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Options { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }
    }
}
