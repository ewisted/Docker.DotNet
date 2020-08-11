using System.Collections.Generic;
using System.Runtime.Serialization;
#if !NETSTANDARD2_1
using Newtonsoft.Json;
#else 
using System.Text.Json.Serialization;
#endif

namespace Docker.DotNet.Models
{
    public class ObjectExtensionData
    {
        [JsonExtensionDataAttribute]
        public IDictionary<string, object> ExtensionData { get; set; }
    }
}