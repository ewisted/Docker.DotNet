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
    public class ImagesListParameters // (main.ImagesListParameters)
    {
        [QueryStringParameter("filter", false)]
        public string MatchName { get; set; }

        [QueryStringParameter("all", false, typeof(BoolQueryStringConverter))]
        public bool? All { get; set; }

        [QueryStringParameter("filters", false, typeof(MapQueryStringConverter))]
        public IDictionary<string, IDictionary<string, bool>> Filters { get; set; }
    }
}
