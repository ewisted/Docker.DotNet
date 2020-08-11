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
    public class ContainerAttachParameters // (main.ContainerAttachParameters)
    {
        [QueryStringParameter("stream", false, typeof(BoolQueryStringConverter))]
        public bool? Stream { get; set; }

        [QueryStringParameter("stdin", false, typeof(BoolQueryStringConverter))]
        public bool? Stdin { get; set; }

        [QueryStringParameter("stdout", false, typeof(BoolQueryStringConverter))]
        public bool? Stdout { get; set; }

        [QueryStringParameter("stderr", false, typeof(BoolQueryStringConverter))]
        public bool? Stderr { get; set; }

        [QueryStringParameter("detachKeys", false)]
        public string DetachKeys { get; set; }

        [QueryStringParameter("logs", false)]
        public string Logs { get; set; }
    }
}
