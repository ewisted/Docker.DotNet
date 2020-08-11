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
    public class ContainerProcessesResponse // (container.ContainerTopOKBody)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Processes")]
#else
        [DataMember(Name = "Processes", EmitDefaultValue = false)]
#endif
        public IList<IList<string>> Processes { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Titles")]
#else
        [DataMember(Name = "Titles", EmitDefaultValue = false)]
#endif
        public IList<string> Titles { get; set; }
    }
}
