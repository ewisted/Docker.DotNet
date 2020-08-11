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
    public class SummaryNetworkSettings // (types.SummaryNetworkSettings)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Networks")]
#else
        [DataMember(Name = "Networks", EmitDefaultValue = false)]
#endif
        public IDictionary<string, EndpointSettings> Networks { get; set; }
    }
}
