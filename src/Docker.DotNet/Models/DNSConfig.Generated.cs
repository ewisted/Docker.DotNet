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
    public class DNSConfig // (swarm.DNSConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Nameservers")]
#else
        [DataMember(Name = "Nameservers", EmitDefaultValue = false)]
#endif
        public IList<string> Nameservers { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Search")]
#else
        [DataMember(Name = "Search", EmitDefaultValue = false)]
#endif
        public IList<string> Search { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Options")]
#else
        [DataMember(Name = "Options", EmitDefaultValue = false)]
#endif
        public IList<string> Options { get; set; }
    }
}
