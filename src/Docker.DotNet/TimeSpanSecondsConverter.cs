using System;
#if NETSTANDARD2_1
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Buffers;
using System.Buffers.Text;
#else
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#endif

namespace Docker.DotNet
{
#if NETSTANDARD2_1
    internal class TimeSpanSecondsConverter : JsonConverter<TimeSpan>
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
#endif
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan) || objectType == typeof(TimeSpan?);
        }
    }
}