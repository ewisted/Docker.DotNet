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
    public class ContainerLogsParameters // (main.ContainerLogsParameters)
    {
        [QueryStringParameter("stdout", false, typeof(BoolQueryStringConverter))]
        public bool? ShowStdout { get; set; }

        [QueryStringParameter("stderr", false, typeof(BoolQueryStringConverter))]
        public bool? ShowStderr { get; set; }

        [QueryStringParameter("since", false)]
        public string Since { get; set; }

        [QueryStringParameter("timestamps", false, typeof(BoolQueryStringConverter))]
        public bool? Timestamps { get; set; }

        [QueryStringParameter("follow", false, typeof(BoolQueryStringConverter))]
        public bool? Follow { get; set; }

        [QueryStringParameter("tail", false)]
        public string Tail { get; set; }
    }
}
