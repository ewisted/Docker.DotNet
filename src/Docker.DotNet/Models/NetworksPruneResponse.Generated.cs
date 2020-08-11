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
    public class NetworksPruneResponse // (types.NetworksPruneReport)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("NetworksDeleted")]
#else
        [DataMember(Name = "NetworksDeleted", EmitDefaultValue = false)]
#endif
        public IList<string> NetworksDeleted { get; set; }
    }
}
