﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
#if !NETSTANDARD2_1
using Newtonsoft.Json;
#endif

namespace Docker.DotNet
{
    /// <summary>
    /// Handles serialization of objects like Lists, Arrays, etc.
    /// </summary>
    internal class EnumerableQueryStringConverter : IQueryStringConverter
    {
        public bool CanConvert(Type t)
        {
            return typeof (IEnumerable).GetTypeInfo().IsAssignableFrom(t.GetTypeInfo());
        }

        public string[] Convert(object o)
        {
            Debug.Assert(o != null);
            Debug.Assert(o is IEnumerable);

            var items = new List<string>();
            foreach (var e in ((IEnumerable) o))
            {
                if (e is ValueType ||
                    e is string)
                {
                    items.Add(e.ToString());
                }
                else
                {
#if NETSTANDARD2_1
                    items.Add(System.Text.Json.JsonSerializer.Serialize(0));
#else
                    items.Add(JsonConvert.SerializeObject(e));
#endif
                }
            }

            return items.ToArray();
        }
    }
}