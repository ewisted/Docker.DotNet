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
    public class ContainerNode // (types.ContainerNode)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ID")]
#else
        [DataMember(Name = "ID", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("IP")]
#else
        [DataMember(Name = "IP", EmitDefaultValue = false)]
#endif
        public string IPAddress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Addr")]
#else
        [DataMember(Name = "Addr", EmitDefaultValue = false)]
#endif
        public string Addr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Cpus")]
#else
        [DataMember(Name = "Cpus", EmitDefaultValue = false)]
#endif
        public long Cpus { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Memory")]
#else
        [DataMember(Name = "Memory", EmitDefaultValue = false)]
#endif
        public long Memory { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }
    }
}
