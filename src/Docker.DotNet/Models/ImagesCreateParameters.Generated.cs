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
    public class ImagesCreateParameters // (main.ImagesCreateParameters)
    {
        [QueryStringParameter("fromImage", false)]
        public string FromImage { get; set; }

        [QueryStringParameter("fromSrc", false)]
        public string FromSrc { get; set; }

        [QueryStringParameter("repo", false)]
        public string Repo { get; set; }

        [QueryStringParameter("tag", false)]
        public string Tag { get; set; }
    }
}
