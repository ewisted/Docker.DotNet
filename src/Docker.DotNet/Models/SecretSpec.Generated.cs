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
    public class SecretSpec // (swarm.SecretSpec)
    {
        public SecretSpec()
        {
        }

        public SecretSpec(Annotations Annotations)
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
        [JsonPropertyName("Data")]
#else
        [DataMember(Name = "Data", EmitDefaultValue = false)]
#endif
        public IList<byte> Data { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Driver")]
#else
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
#endif
        public SwarmDriver Driver { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Templating")]
#else
        [DataMember(Name = "Templating", EmitDefaultValue = false)]
#endif
        public SwarmDriver Templating { get; set; }
    }
}
