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
    public class SwarmUnlockResponse // (main.SwarmUnlockResponse)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("UnlockKey")]
#else
        [DataMember(Name = "UnlockKey", EmitDefaultValue = false)]
#endif
        public string UnlockKey { get; set; }
    }
}
