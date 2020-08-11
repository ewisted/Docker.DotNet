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
    public class CAConfig // (swarm.CAConfig)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("NodeCertExpiry")]
#else
        [DataMember(Name = "NodeCertExpiry", EmitDefaultValue = false)]
#endif
        public long NodeCertExpiry { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ExternalCAs")]
#else
        [DataMember(Name = "ExternalCAs", EmitDefaultValue = false)]
#endif
        public IList<ExternalCA> ExternalCAs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SigningCACert")]
#else
        [DataMember(Name = "SigningCACert", EmitDefaultValue = false)]
#endif
        public string SigningCACert { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SigningCAKey")]
#else
        [DataMember(Name = "SigningCAKey", EmitDefaultValue = false)]
#endif
        public string SigningCAKey { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ForceRotate")]
#else
        [DataMember(Name = "ForceRotate", EmitDefaultValue = false)]
#endif
        public ulong ForceRotate { get; set; }
    }
}
