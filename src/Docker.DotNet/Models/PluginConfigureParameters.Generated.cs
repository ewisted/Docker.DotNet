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
    public class PluginConfigureParameters // (main.PluginConfigureParameters)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Args")]
#else
        [DataMember(Name = "Args", EmitDefaultValue = false)]
#endif
        public IList<string> Args { get; set; }
    }
}
