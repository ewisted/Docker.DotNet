using System;
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
#if NETSTANDARD2_1
    internal class TimeSpanNanosecondsConverter : JsonConverter<TimeSpan?>
    {
        const int MilliSecondToNanoSecond = 1000000;
        public override void Write(Utf8JsonWriter writer, TimeSpan? value, JsonSerializerOptions serializerOptions)
        {
            if (!value.HasValue)
            {
                return;
            }

            writer.WriteNumberValue(value.Value.TotalMilliseconds * MilliSecondToNanoSecond);
        }

        public override TimeSpan? Read(ref Utf8JsonReader reader, Type objectType, JsonSerializerOptions serializerOptions)
        {
            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
            if (Utf8Parser.TryParse(span, out long valueInNanoSeconds, out int bytesConsumed) && span.Length == bytesConsumed)
            {
                var milliSecondValue = valueInNanoSeconds / MilliSecondToNanoSecond;
                return TimeSpan.FromMilliseconds(milliSecondValue);
            }
            else
            {
                return null;
            }
        }
#else
    internal class TimeSpanNanosecondsConverter : JsonConverter
    {
        const int MilliSecondToNanoSecond = 1000000;
        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            var timeSpan = value as TimeSpan?;
            if (timeSpan == null)
            {
                return;
            }

            writer.WriteValue((long)(timeSpan.Value.TotalMilliseconds * MilliSecondToNanoSecond));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var valueInNanoSeconds = (long?)reader.Value;

            if (!valueInNanoSeconds.HasValue)
            {
                return null;
            }
            var milliSecondValue = valueInNanoSeconds.Value / MilliSecondToNanoSecond;

            return TimeSpan.FromMilliseconds((long)milliSecondValue);
        }
#endif
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan) || objectType == typeof(TimeSpan?);
        }
    }
}