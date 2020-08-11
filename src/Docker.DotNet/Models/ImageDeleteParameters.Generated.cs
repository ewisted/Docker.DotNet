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
    public class ImageDeleteParameters // (main.ImageDeleteParameters)
    {
        [QueryStringParameter("force", false, typeof(BoolQueryStringConverter))]
        public bool? Force { get; set; }

        [QueryStringParameter("noprune", false, typeof(BoolQueryStringConverter))]
        public bool? NoPrune { get; set; }
    }
}
