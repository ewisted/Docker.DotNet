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
    public class Actor // (events.Actor)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ID")]
#else
        [DataMember(Name = "ID", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Attributes")]
#else
        [DataMember(Name = "Attributes", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Attributes { get; set; }
    }
}
