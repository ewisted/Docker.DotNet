#if NETSTANDARD2_1
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text;
using System;
#else
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
#endif

namespace Docker.DotNet
{
    /// <summary>
    /// Facade for <see cref="JsonConvert"/>.
    /// </summary>
    internal class JsonSerializer
    {
#if NETSTANDARD2_1
        private readonly System.Text.Json.JsonSerializerOptions _settings = new System.Text.Json.JsonSerializerOptions
        {
            IgnoreNullValues = true
        };

        public JsonSerializer()
        {
            _settings.Converters.Add(new JsonIso8601AndUnixEpochDateConverter());
            _settings.Converters.Add(new JsonVersionConverter());
            _settings.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter(new DockerApiJsonNamingPolicy()));
            _settings.Converters.Add(new TimeSpanSecondsConverter());
            _settings.Converters.Add(new TimeSpanNanosecondsConverter());
        }

        public T DeserializeObject<T>(string json)
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(json, this._settings);
        }

        public string SerializeObject<T>(T value)
        {
            return System.Text.Json.JsonSerializer.Serialize(value, this._settings);
        }
#else
        private readonly JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Converters = new JsonConverter[]
            {
                new JsonIso8601AndUnixEpochDateConverter(),
                new JsonVersionConverter(),
                new StringEnumConverter(),
                new TimeSpanSecondsConverter(),
                new TimeSpanNanosecondsConverter()
            }
        };

        public JsonSerializer()
        {
        }

        public T DeserializeObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, this._settings);
        }

        public string SerializeObject<T>(T value)
        {
            return JsonConvert.SerializeObject(value, this._settings);
        }
#endif
    }

#if NETSTANDARD2_1
    internal class DockerApiJsonNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return name;

            var sb = new StringBuilder();

            for (var i = 0; i < name.Length; i++)
            {
                if (i > 0)
                {
                    if (Char.IsUpper(name[i]) && Char.IsLower(name[i - 1]))
                    {
                        sb.Append("-");
                    }
                }
                sb.Append(name[i].ToString().ToLower());
            }

            return sb.ToString();
        }
    }
#endif
}