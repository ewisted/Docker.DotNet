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
    public class NetworkAttachmentSpec // (swarm.NetworkAttachmentSpec)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ContainerID")]
#else
        [DataMember(Name = "ContainerID", EmitDefaultValue = false)]
#endif
        public string ContainerID { get; set; }
    }
}
