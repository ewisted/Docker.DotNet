using System;
using System.Diagnostics;

#if NETSTANDARD2_1
using System.Text.Json;
using System.Text.Json.Serialization;
#else
using Newtonsoft.Json;
#endif

namespace Docker.DotNet.Models
{
    internal class JsonQueryStringConverter : IQueryStringConverter
    {
        public bool CanConvert(Type t)
        {
            return true;
        }

        public string[] Convert(object o)
        {
            Debug.Assert(o != null);
#if NETSTANDARD2_1
            return new[] {System.Text.Json.JsonSerializer.Serialize(o)};
#else
            return new[] {JsonConvert.SerializeObject(o, Formatting.None)};
#endif
        }
    }
}