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
    public class SwarmUpdateParameters // (main.SwarmUpdateParameters)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Spec")]
#else
        [DataMember(Name = "Spec", EmitDefaultValue = false)]
#endif
        public Spec Spec { get; set; }

        [QueryStringParameter("version", true)]
        public long Version { get; set; }

        [QueryStringParameter("rotateworkertoken", false, typeof(BoolQueryStringConverter))]
        public bool? RotateWorkerToken { get; set; }

        [QueryStringParameter("rotatemanagertoken", false, typeof(BoolQueryStringConverter))]
        public bool? RotateManagerToken { get; set; }

        [QueryStringParameter("rotatemanagerunlockkey", false, typeof(BoolQueryStringConverter))]
        public bool? RotateManagerUnlockKey { get; set; }
    }
}
