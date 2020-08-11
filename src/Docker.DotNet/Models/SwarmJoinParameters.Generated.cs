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
    public class SwarmJoinParameters // (swarm.JoinRequest)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("ListenAddr")]
#else
        [DataMember(Name = "ListenAddr", EmitDefaultValue = false)]
#endif
        public string ListenAddr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AdvertiseAddr")]
#else
        [DataMember(Name = "AdvertiseAddr", EmitDefaultValue = false)]
#endif
        public string AdvertiseAddr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DataPathAddr")]
#else
        [DataMember(Name = "DataPathAddr", EmitDefaultValue = false)]
#endif
        public string DataPathAddr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("RemoteAddrs")]
#else
        [DataMember(Name = "RemoteAddrs", EmitDefaultValue = false)]
#endif
        public IList<string> RemoteAddrs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("JoinToken")]
#else
        [DataMember(Name = "JoinToken", EmitDefaultValue = false)]
#endif
        public string JoinToken { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Availability")]
#else
        [DataMember(Name = "Availability", EmitDefaultValue = false)]
#endif
        public string Availability { get; set; }
    }
}
