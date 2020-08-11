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
    public class ContainerRemoveParameters // (main.ContainerRemoveParameters)
    {
        [QueryStringParameter("v", false, typeof(BoolQueryStringConverter))]
        public bool? RemoveVolumes { get; set; }

        [QueryStringParameter("link", false, typeof(BoolQueryStringConverter))]
        public bool? RemoveLinks { get; set; }

        [QueryStringParameter("force", false, typeof(BoolQueryStringConverter))]
        public bool? Force { get; set; }
    }
}
