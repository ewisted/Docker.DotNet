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
    public class ContainerWaitResponse // (main.ContainerWaitResponse)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("StatusCode")]
#else
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
#endif
        public long StatusCode { get; set; }
    }
}
