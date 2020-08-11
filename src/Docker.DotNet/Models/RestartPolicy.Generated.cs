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
    public class RestartPolicy // (container.RestartPolicy)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Name")]
#else
        [DataMember(Name = "Name", EmitDefaultValue = false)]
#endif
        public RestartPolicyKind Name { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MaximumRetryCount")]
#else
        [DataMember(Name = "MaximumRetryCount", EmitDefaultValue = false)]
#endif
        public long MaximumRetryCount { get; set; }
    }
}
