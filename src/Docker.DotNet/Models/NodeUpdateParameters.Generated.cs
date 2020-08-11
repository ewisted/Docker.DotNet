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
    public class NodeUpdateParameters // (swarm.NodeSpec)
    {
        public NodeUpdateParameters()
        {
        }

        public NodeUpdateParameters(Annotations Annotations)
        {
            if (Annotations != null)
            {
                this.Name = Annotations.Name;
                this.Labels = Annotations.Labels;
            }
        }

#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Role")]
#else
        [DataMember(Name = "Role", EmitDefaultValue = false)]
#endif
        public string Role { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Availability")]
#else
        [DataMember(Name = "Availability", EmitDefaultValue = false)]
#endif
        public string Availability { get; set; }
    }
}
