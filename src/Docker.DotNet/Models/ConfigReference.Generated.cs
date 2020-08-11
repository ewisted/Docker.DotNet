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
    public class ConfigReference // (network.ConfigReference)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Network")]
#else
        [DataMember(Name = "Network", EmitDefaultValue = false)]
#endif
        public string Network { get; set; }
    }
}
