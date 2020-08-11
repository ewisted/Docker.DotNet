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
    public class NetworkAttachment // (swarm.NetworkAttachment)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Network")]
#else
        [DataMember(Name = "Network", EmitDefaultValue = false)]
#endif
        public Network Network { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Addresses")]
#else
        [DataMember(Name = "Addresses", EmitDefaultValue = false)]
#endif
        public IList<string> Addresses { get; set; }
    }
}
