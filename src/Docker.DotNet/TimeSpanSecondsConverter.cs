using System;
using System.Reflection;
#if NETSTANDARD2_1
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Buffers;
using System.Buffers.Text;
using System.Globalization;
#else
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#endif

namespace Docker.DotNet
{
#if NETSTANDARD2_1
    internal class TimeSpanSecondsConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan) || objectType == typeof(TimeSpan?);
        }

        public override JsonConverter CreateConverter(Type objectType, JsonSerializerOptions options)
        {
            if (objectType == typeof(TimeSpan))
            {
                return (JsonConverter)Activator.CreateInstance(
                    typeof(TimeSpanSecondsConverterInner),
                    BindingFlags.Instance | BindingFlags.Public,
                    binder: null,
                    args: null,
                    culture: CultureInfo.InvariantCulture);
            }
            else if (objectType == typeof(TimeSpan?))
            {
                return (JsonConverter)Activator.CreateInstance(
                    typeof(NullableTimeSpanSecondsConverterInner),
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

    internal class TimeSpanSecondsConverterInner : JsonConverter<TimeSpan>
    {
        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions serializerOptions)
        {
            if (value == default(TimeSpan))
            {
                return;
            }

            writer.WriteNumberValue((long)value.TotalSeconds);
        }

        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
            if (Utf8Parser.TryParse(span, out long valueInSeconds, out int bytesConsumed) && span.Length == bytesConsumed)
            {
                return TimeSpan.FromSeconds(valueInSeconds);
            }
            else
            {
                return default(TimeSpan);
            }
        }
    }

    internal class NullableTimeSpanSecondsConverterInner : JsonConverter<TimeSpan?>
    {
        public override void Write(Utf8JsonWriter writer, TimeSpan? value, JsonSerializerOptions serializerOptions)
        {
            var timeSpan = value as TimeSpan?;
            if (timeSpan == null)
            {
                return;
            }

            writer.WriteNumberValue((long)timeSpan.Value.TotalSeconds);
        }

        public override TimeSpan? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
            if (Utf8Parser.TryParse(span, out long valueInSeconds, out int bytesConsumed) && span.Length == bytesConsumed)
            {
                return TimeSpan.FromSeconds(valueInSeconds);
            }
            else
            {
                return null;
            }
        }
    }
#else
    internal class TimeSpanSecondsConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            var timeSpan = value as TimeSpan?;
            if (timeSpan == null)
            {
                return;
            }

            writer.WriteValue((long)timeSpan.Value.TotalSeconds);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var valueInSeconds = (long?)reader.Value;
            if(!valueInSeconds.HasValue)
            {
                return null;
            }

            return TimeSpan.FromSeconds(valueInSeconds.Value);
        }
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan) || objectType == typeof(TimeSpan?);
        }
    }
#endif
}