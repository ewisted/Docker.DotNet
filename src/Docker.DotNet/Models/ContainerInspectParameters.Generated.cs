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
    public class ContainerInspectParameters // (main.ContainerInspectParameters)
    {
        [QueryStringParameter("size", false, typeof(BoolQueryStringConverter))]
        public bool? IncludeSize { get; set; }
    }
}
