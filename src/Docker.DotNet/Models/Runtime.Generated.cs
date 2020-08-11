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
    public class Runtime // (types.Runtime)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("path")]
#else
        [DataMember(Name = "path", EmitDefaultValue = false)]
#endif
        public string Path { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("runtimeArgs")]
#else
        [DataMember(Name = "runtimeArgs", EmitDefaultValue = false)]
#endif
        public IList<string> Args { get; set; }
    }
}
