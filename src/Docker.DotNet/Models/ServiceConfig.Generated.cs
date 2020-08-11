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
    public class ServiceConfig // (registry.ServiceConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("AllowNondistributableArtifactsCIDRs")]
#else
        [DataMember(Name = "AllowNondistributableArtifactsCIDRs", EmitDefaultValue = false)]
#endif
        public IList<string> AllowNondistributableArtifactsCIDRs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AllowNondistributableArtifactsHostnames")]
#else
        [DataMember(Name = "AllowNondistributableArtifactsHostnames", EmitDefaultValue = false)]
#endif
        public IList<string> AllowNondistributableArtifactsHostnames { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("InsecureRegistryCIDRs")]
#else
        [DataMember(Name = "InsecureRegistryCIDRs", EmitDefaultValue = false)]
#endif
        public IList<string> InsecureRegistryCIDRs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IndexConfigs")]
#else
        [DataMember(Name = "IndexConfigs", EmitDefaultValue = false)]
#endif
        public IDictionary<string, IndexInfo> IndexConfigs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mirrors")]
#else
        [DataMember(Name = "Mirrors", EmitDefaultValue = false)]
#endif
        public IList<string> Mirrors { get; set; }
    }
}
