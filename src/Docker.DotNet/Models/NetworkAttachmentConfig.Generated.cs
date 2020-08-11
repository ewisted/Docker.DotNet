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
    public class NetworkAttachmentConfig // (swarm.NetworkAttachmentConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Target")]
#else
        [DataMember(Name = "Target", EmitDefaultValue = false)]
#endif
        public string Target { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Aliases")]
#else
        [DataMember(Name = "Aliases", EmitDefaultValue = false)]
#endif
        public IList<string> Aliases { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DriverOpts")]
#else
        [DataMember(Name = "DriverOpts", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> DriverOpts { get; set; }
    }
}
