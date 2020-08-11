using System;
using System.Globalization;

#if NETSTANDARD2_1
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Buffers;
using System.Buffers.Text;
#else
using Newtonsoft.Json;
#endif

namespace Docker.DotNet
{
    using System.Reflection;

#if NETSTANDARD2_1
    internal class JsonIso8601AndUnixEpochDateConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime) || objectType == typeof(DateTime?);
        }

        public override JsonConverter CreateConverter(Type objectType, JsonSerializerOptions options)
        {
            if (objectType == typeof(DateTime))
            {
                return (JsonConverter)Activator.CreateInstance(
                    typeof(JsonIso8601AndUnixEpochDateConverterInner),
                    BindingFlags.Instance | BindingFlags.Public,
                    binder: null,
                    args: null,
                    culture: CultureInfo.InvariantCulture);
            }
            else if (objectType == typeof(DateTime?))
            {
                return (JsonConverter)Activator.CreateInstance(
                    typeof(NullableJsonIso8601AndUnixEpochDateConverterInner),
                    BindingFlags.Instance | BindingFlags.Public,
                    binder: null,
                    args: null,
                    culture: CultureInfo.InvariantCulture);
            }
            else
            {
                return null;
            }
        }
    }

    internal class JsonIso8601AndUnixEpochDateConverterInner : JsonConverter<DateTime>
    {
        private static readonly DateTime UnixEpochBase = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions serializerOptions)
        {
            throw new NotImplementedException();
        }

        public override DateTime Read(ref Utf8JsonReader reader, Type objectType, JsonSerializerOptions serializerOptions)
        {
            DateTime result;

            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
            if (reader.TryGetDateTime(out DateTime dateTimeValue))
            {
                result = dateTimeValue;
            }
            else if (DateTime.TryParse(reader.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out DateTime stringValue))
            {
                result = stringValue;
            }
            else if (Utf8Parser.TryParse(span, out long longValue, out int bytesConsumed) && span.Length == bytesConsumed)
            {
                result = UnixEpochBase.AddSeconds(longValue);
            }
            else
            {
                throw new NotImplementedException($"Deserializing {reader.TokenType} back to {objectType.FullName} is not handled.");
            }

            return result;
        }
    }

    internal class NullableJsonIso8601AndUnixEpochDateConverterInner : JsonConverter<DateTime?>
    {
        private static readonly DateTime UnixEpochBase = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions serializerOptions)
        {
            throw new NotImplementedException();
        }

        public override DateTime? Read(ref Utf8JsonReader reader, Type objectType, JsonSerializerOptions serializerOptions)
        {
            DateTime result;

            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
            if (reader.TryGetDateTime(out DateTime dateTimeValue))
            {
                result = dateTimeValue;
            }
            else if (DateTime.TryParse(reader.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out DateTime stringValue))
            {
                result = stringValue;
            }
            else if (Utf8Parser.TryParse(span, out long longValue, out int bytesConsumed) && span.Length == bytesConsumed)
            {
                result = UnixEpochBase.AddSeconds(longValue);
            }
            else
            {
                throw new NotImplementedException($"Deserializing {reader.TokenType} back to {objectType.FullName} is not handled.");
            }
            if (result == default(DateTime))
            {
                return null; // do not set result on DateTime? field
            }

            return result;
        }
    }
#else
    internal class JsonIso8601AndUnixEpochDateConverter : JsonConverter
    {
        private static readonly DateTime UnixEpochBase = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof (DateTime) || objectType == typeof (DateTime?);
        }

        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var isNullableType = (objectType.GetTypeInfo().IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>));
            DateTime result;

            var value = reader.Value;

            if (value is DateTime)
            {
                result = (DateTime) value;
            }
            else if (value is string)
            {
                // ISO 8601 String
                result = DateTime.Parse((string) value, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
            }
            else if (value is long)
            {
                // UNIX epoch timestamp (in seconds)
                result = UnixEpochBase.AddSeconds((long) value);
            }
            else
            {
                throw new NotImplementedException($"Deserializing {value.GetType().FullName} back to {objectType.FullName} is not handled.");
            }

            if (isNullableType && result == default(DateTime))
            {
                return null; // do not set result on DateTime? field
            }

            return result;
        }
    }
#endif
}