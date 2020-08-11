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
    public class ServiceInfo // (network.ServiceInfo)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("VIP")]
#else
        [DataMember(Name = "VIP", EmitDefaultValue = false)]
#endif
        public string VIP { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Ports")]
#else
        [DataMember(Name = "Ports", EmitDefaultValue = false)]
#endif
        public IList<string> Ports { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("LocalLBIndex")]
#else
        [DataMember(Name = "LocalLBIndex", EmitDefaultValue = false)]
#endif
        public long LocalLBIndex { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Tasks")]
#else
        [DataMember(Name = "Tasks", EmitDefaultValue = false)]
#endif
        public IList<NetworkTask> Tasks { get; set; }
    }
}
