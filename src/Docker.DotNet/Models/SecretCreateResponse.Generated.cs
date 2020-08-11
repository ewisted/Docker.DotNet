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
    public class SecretCreateResponse // (main.SecretCreateResponse)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ID")]
#else
        [DataMember(Name = "ID", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }
    }
}
