using System.Collections.Generic;
#if !NETSTANDARD2_1
using System.Runtime.Serialization;
#else
using System.Text.Json.Serialization;
#endif

namespace Docker.DotNet.Models
{
#if !NETSTANDARD2_1
    [DataContract]
#endif
    public class ContainerExecCreateParameters // (main.ContainerExecCreateParameters)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("User")]
#else
        [DataMember(Name = "User", EmitDefaultValue = false)]
#endif
        public string User { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Privileged")]
#else
        [DataMember(Name = "Privileged", EmitDefaultValue = false)]
#endif
        public bool Privileged { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Tty")]
#else
        [DataMember(Name = "Tty", EmitDefaultValue = false)]
#endif
        public bool Tty { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AttachStdin")]
#else
        [DataMember(Name = "AttachStdin", EmitDefaultValue = false)]
#endif
        public bool AttachStdin { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AttachStderr")]
#else
        [DataMember(Name = "AttachStderr", EmitDefaultValue = false)]
#endif
        public bool AttachStderr { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("AttachStdout")]
#else
        [DataMember(Name = "AttachStdout", EmitDefaultValue = false)]
#endif
        public bool AttachStdout { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Detach")]
#else
        [DataMember(Name = "Detach", EmitDefaultValue = false)]
#endif
        public bool Detach { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("DetachKeys")]
#else
        [DataMember(Name = "DetachKeys", EmitDefaultValue = false)]
#endif
        public string DetachKeys { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Env")]
#else
        [DataMember(Name = "Env", EmitDefaultValue = false)]
#endif
        public IList<string> Env { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("WorkingDir")]
#else
        [DataMember(Name = "WorkingDir", EmitDefaultValue = false)]
#endif
        public string WorkingDir { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Cmd")]
#else
        [DataMember(Name = "Cmd", EmitDefaultValue = false)]
#endif
        public IList<string> Cmd { get; set; }
    }
}
