using System;
using System.Collections.Generic;
#if !NETSTANDARD2_1
using System.Runtime.Serialization;
#else
using System.Text.Json.Serialization;
#endif
#if !NETSTANDARD2_1
using Newtonsoft.Json;
#else
using System.Text.Json;
#endif

namespace Docker.DotNet.Models
{
#if !NETSTANDARD2_1
    [DataContract]
#endif
    public class Config // (container.Config)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Hostname")]
#else
        [DataMember(Name = "Hostname", EmitDefaultValue = false)]
#endif
        public string Hostname { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Domainname")]
#else
        [DataMember(Name = "Domainname", EmitDefaultValue = false)]
#endif
        public string Domainname { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("User")]
#else
        [DataMember(Name = "User", EmitDefaultValue = false)]
#endif
        public string User { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AttachStdin")]
#else
        [DataMember(Name = "AttachStdin", EmitDefaultValue = false)]
#endif
        public bool AttachStdin { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AttachStdout")]
#else
        [DataMember(Name = "AttachStdout", EmitDefaultValue = false)]
#endif
        public bool AttachStdout { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AttachStderr")]
#else
        [DataMember(Name = "AttachStderr", EmitDefaultValue = false)]
#endif
        public bool AttachStderr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ExposedPorts")]
#else
        [DataMember(Name = "ExposedPorts", EmitDefaultValue = false)]
#endif
        public IDictionary<string, EmptyStruct> ExposedPorts { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Tty")]
#else
        [DataMember(Name = "Tty", EmitDefaultValue = false)]
#endif
        public bool Tty { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OpenStdin")]
#else
        [DataMember(Name = "OpenStdin", EmitDefaultValue = false)]
#endif
        public bool OpenStdin { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("StdinOnce")]
#else
        [DataMember(Name = "StdinOnce", EmitDefaultValue = false)]
#endif
        public bool StdinOnce { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Env")]
#else
        [DataMember(Name = "Env", EmitDefaultValue = false)]
#endif
        public IList<string> Env { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Cmd")]
#else
        [DataMember(Name = "Cmd", EmitDefaultValue = false)]
#endif
        public IList<string> Cmd { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Healthcheck")]
#else
        [DataMember(Name = "Healthcheck", EmitDefaultValue = false)]
#endif
        public HealthConfig Healthcheck { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ArgsEscaped")]
#else
        [DataMember(Name = "ArgsEscaped", EmitDefaultValue = false)]
#endif
        public bool ArgsEscaped { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Image")]
#else
        [DataMember(Name = "Image", EmitDefaultValue = false)]
#endif
        public string Image { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Volumes")]
#else
        [DataMember(Name = "Volumes", EmitDefaultValue = false)]
#endif
        public IDictionary<string, EmptyStruct> Volumes { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("WorkingDir")]
#else
        [DataMember(Name = "WorkingDir", EmitDefaultValue = false)]
#endif
        public string WorkingDir { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Entrypoint")]
#else
        [DataMember(Name = "Entrypoint", EmitDefaultValue = false)]
#endif
        public IList<string> Entrypoint { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NetworkDisabled")]
#else
        [DataMember(Name = "NetworkDisabled", EmitDefaultValue = false)]
#endif
        public bool NetworkDisabled { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MacAddress")]
#else
        [DataMember(Name = "MacAddress", EmitDefaultValue = false)]
#endif
        public string MacAddress { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("OnBuild")]
#else
        [DataMember(Name = "OnBuild", EmitDefaultValue = false)]
#endif
        public IList<string> OnBuild { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("StopSignal")]
#else
        [DataMember(Name = "StopSignal", EmitDefaultValue = false)]
#endif
        public string StopSignal { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("StopTimeout")]
#else
        [DataMember(Name = "StopTimeout", EmitDefaultValue = false)]
#endif
        [JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan? StopTimeout { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Shell")]
#else
        [DataMember(Name = "Shell", EmitDefaultValue = false)]
#endif
        public IList<string> Shell { get; set; }
    }
}
