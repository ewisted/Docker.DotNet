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
    public class NetworkSpec // (swarm.NetworkSpec)
    {
        public NetworkSpec()
        {
        }

        public NetworkSpec(Annotations Annotations)
        {
            if (Annotations != null)
            {
                this.Name = Annotations.Name;
                this.Labels = Annotations.Labels;
            }
        }

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
        public IDictionary<string, string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DriverConfiguration")]
#else
        [DataMember(Name = "DriverConfiguration", EmitDefaultValue = false)]
#endif
        public SwarmDriver DriverConfiguration { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IPv6Enabled")]
#else
        [DataMember(Name = "IPv6Enabled", EmitDefaultValue = false)]
#endif
        public bool IPv6Enabled { get; set; }

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
        [JsonPropertyName("IPAMOptions")]
#else
        [DataMember(Name = "IPAMOptions", EmitDefaultValue = false)]
#endif
        public IPAMOptions IPAMOptions { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ConfigFrom")]
#else
        [DataMember(Name = "ConfigFrom", EmitDefaultValue = false)]
#endif
        public ConfigReference ConfigFrom { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Scope")]
#else
        [DataMember(Name = "Scope", EmitDefaultValue = false)]
#endif
        public string Scope { get; set; }
    }
}
