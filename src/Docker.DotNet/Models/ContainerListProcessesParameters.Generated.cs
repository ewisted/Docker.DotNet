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
    public class ContainerListProcessesParameters // (main.ContainerListProcessesParameters)
    {
        [QueryStringParameter("ps_args", false)]
        public string PsArgs { get; set; }
    }
}
