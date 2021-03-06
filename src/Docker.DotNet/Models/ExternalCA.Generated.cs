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
    public class ExternalCA // (swarm.ExternalCA)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Protocol")]
#else
        [DataMember(Name = "Protocol", EmitDefaultValue = false)]
#endif
        public string Protocol { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("URL")]
#else
        [DataMember(Name = "URL", EmitDefaultValue = false)]
#endif
        public string URL { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Options")]
#else
        [DataMember(Name = "Options", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Options { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CACert")]
#else
        [DataMember(Name = "CACert", EmitDefaultValue = false)]
#endif
        public string CACert { get; set; }
    }
}
