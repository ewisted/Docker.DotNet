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
    public class ContainerResizeParameters // (main.ContainerResizeParameters)
    {
        [QueryStringParameter("h", false)]
        public long? Height { get; set; }

        [QueryStringParameter("w", false)]
        public long? Width { get; set; }
    }
}
