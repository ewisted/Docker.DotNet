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
    public class ImageLoadParameters // (main.ImageLoadParameters)
    {
        [QueryStringParameter("quiet", true, typeof(BoolQueryStringConverter))]
        public bool Quiet { get; set; }
    }
}
