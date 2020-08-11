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
    public class CommitContainerChangesParameters // (main.CommitContainerChangesParameters)
    {
        [QueryStringParameter("container", true)]
        public string ContainerID { get; set; }

        [QueryStringParameter("repo", false)]
        public string RepositoryName { get; set; }

        [QueryStringParameter("tag", false)]
        public string Tag { get; set; }

        [QueryStringParameter("comment", false)]
        public string Comment { get; set; }

        [QueryStringParameter("author", false)]
        public string Author { get; set; }

        [QueryStringParameter("changes", false, typeof(EnumerableQueryStringConverter))]
        public IList<string> Changes { get; set; }

        [QueryStringParameter("pause", false, typeof(BoolQueryStringConverter))]
        public bool? Pause { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Config")]
#else
        [DataMember(Name = "Config", EmitDefaultValue = false)]
#endif
        public Config Config { get; set; }
    }
}
