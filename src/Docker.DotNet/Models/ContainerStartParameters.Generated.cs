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
    public class ContainerStartParameters // (main.ContainerStartParameters)
    {
        [QueryStringParameter("detachKeys", false)]
        public string DetachKeys { get; set; }
    }
}
