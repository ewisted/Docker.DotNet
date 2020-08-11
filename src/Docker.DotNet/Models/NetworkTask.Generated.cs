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
    public class NetworkTask // (network.Task)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("EndpointID")]
#else
        [DataMember(Name = "EndpointID", EmitDefaultValue = false)]
#endif
        public string EndpointID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("EndpointIP")]
#else
        [DataMember(Name = "EndpointIP", EmitDefaultValue = false)]
#endif
        public string EndpointIP { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Info")]
#else
        [DataMember(Name = "Info", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Info { get; set; }
    }
}
