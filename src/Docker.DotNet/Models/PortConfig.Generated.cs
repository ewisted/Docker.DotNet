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
    public class PortConfig // (swarm.PortConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Protocol")]
#else
        [DataMember(Name = "Protocol", EmitDefaultValue = false)]
#endif
        public string Protocol { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("TargetPort")]
#else
        [DataMember(Name = "TargetPort", EmitDefaultValue = false)]
#endif
        public uint TargetPort { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PublishedPort")]
#else
        [DataMember(Name = "PublishedPort", EmitDefaultValue = false)]
#endif
        public uint PublishedPort { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("PublishMode")]
#else
        [DataMember(Name = "PublishMode", EmitDefaultValue = false)]
#endif
        public string PublishMode { get; set; }
    }
}
