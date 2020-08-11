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
    public class ServiceUpdateResponse // (types.ServiceUpdateResponse)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Warnings")]
#else
        [DataMember(Name = "Warnings", EmitDefaultValue = false)]
#endif
        public IList<string> Warnings { get; set; }
    }
}
