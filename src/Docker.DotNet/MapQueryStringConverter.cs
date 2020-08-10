using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
#if !NETSTANDARD2_1
using Newtonsoft.Json;
#endif

namespace Docker.DotNet
{
    internal class MapQueryStringConverter : IQueryStringConverter
    {
        public bool CanConvert(Type t)
        {
            return typeof(IList).GetTypeInfo().IsAssignableFrom(t.GetTypeInfo()) || typeof(IDictionary).GetTypeInfo().IsAssignableFrom(t.GetTypeInfo());
        }

        public string[] Convert(object o)
        {
            Debug.Assert(o != null);

#if NETSTANDARD2_1
            return new[] { System.Text.Json.JsonSerializer.Serialize(o) };
#else
            return new[] { JsonConvert.SerializeObject(o) };
#endif
        }
    }
}