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
    public class PeerInfo // (network.PeerInfo)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IP")]
#else
        [DataMember(Name = "IP", EmitDefaultValue = false)]
#endif
        public string IP { get; set; }
    }
}
