using System;
#if NETSTANDARD2_1
using System.Text.Json;
using System.Text.Json.Serialization;
#else
using Newtonsoft.Json;
#endif

namespace Docker.DotNet
{
#if NETSTANDARD2_1
    internal class JsonVersionConverter : JsonConverter<Version>
    {
        public override void Write(Utf8JsonWriter writer, Version value, JsonSerializerOptions serializerOptions)
        {
            throw new NotImplementedException();
        }

        public override Version Read(ref Utf8JsonReader reader, Type objectType, JsonSerializerOptions serializerOptions)
        {
            var strVal = reader.GetString();
            if (strVal == null)
            {
                var valueType = reader.TokenType == JsonTokenType.Null ? "<null>" : reader.TokenType.ToString();
                throw new InvalidOperationException($"Cannot deserialize value of type '{valueType}' to '{objectType.FullName}' ");
            }

            return Version.Parse(strVal);
        }
#else
    internal class JsonVersionConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var strVal = reader.Value as string;
            if (strVal == null)
            {
                var valueType = reader.Value == null ? "<null>" : reader.Value.GetType().FullName;
                throw new InvalidOperationException($"Cannot deserialize value of type '{valueType}' to '{objectType.FullName}' ");
            }

            return Version.Parse(strVal);
        }
#endif

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof (Version);
        }
    }
}