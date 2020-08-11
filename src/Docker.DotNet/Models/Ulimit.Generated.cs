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
    public class Ulimit // (units.Ulimit)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public string Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Hard")]
#else
        [DataMember(Name = "Hard", EmitDefaultValue = false)]
#endif
        public long Hard { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Soft")]
#else
        [DataMember(Name = "Soft", EmitDefaultValue = false)]
#endif
        public long Soft { get; set; }
    }
}
