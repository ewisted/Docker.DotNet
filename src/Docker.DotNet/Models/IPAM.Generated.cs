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
    public class IPAM // (network.IPAM)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Driver")]
#else
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
#endif
        public string Driver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Options")]
#else
        [DataMember(Name = "Options", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Options { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Config")]
#else
        [DataMember(Name = "Config", EmitDefaultValue = false)]
#endif
        public IList<IPAMConfig> Config { get; set; }
    }
}
