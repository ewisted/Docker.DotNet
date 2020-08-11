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
    public class TLSInfo // (swarm.TLSInfo)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("TrustRoot")]
#else
        [DataMember(Name = "TrustRoot", EmitDefaultValue = false)]
#endif
        public string TrustRoot { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CertIssuerSubject")]
#else
        [DataMember(Name = "CertIssuerSubject", EmitDefaultValue = false)]
#endif
        public IList<byte> CertIssuerSubject { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("CertIssuerPublicKey")]
#else
        [DataMember(Name = "CertIssuerPublicKey", EmitDefaultValue = false)]
#endif
        public IList<byte> CertIssuerPublicKey { get; set; }
    }
}
