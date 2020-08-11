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
    public class VersionResponse // (types.Version)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Components")]
#else
        [DataMember(Name = "Components", EmitDefaultValue = false)]
#endif
        public IList<ComponentVersion> Components { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Version")]
#else
        [DataMember(Name = "Version", EmitDefaultValue = false)]
#endif
        public string Version { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ApiVersion")]
#else
        [DataMember(Name = "ApiVersion", EmitDefaultValue = false)]
#endif
        public string APIVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("MinAPIVersion")]
#else
        [DataMember(Name = "MinAPIVersion", EmitDefaultValue = false)]
#endif
        public string MinAPIVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GitCommit")]
#else
        [DataMember(Name = "GitCommit", EmitDefaultValue = false)]
#endif
        public string GitCommit { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("GoVersion")]
#else
        [DataMember(Name = "GoVersion", EmitDefaultValue = false)]
#endif
        public string GoVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Os")]
#else
        [DataMember(Name = "Os", EmitDefaultValue = false)]
#endif
        public string Os { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Arch")]
#else
        [DataMember(Name = "Arch", EmitDefaultValue = false)]
#endif
        public string Arch { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("KernelVersion")]
#else
        [DataMember(Name = "KernelVersion", EmitDefaultValue = false)]
#endif
        public string KernelVersion { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Experimental")]
#else
        [DataMember(Name = "Experimental", EmitDefaultValue = false)]
#endif
        public bool Experimental { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("BuildTime")]
#else
        [DataMember(Name = "BuildTime", EmitDefaultValue = false)]
#endif
        public string BuildTime { get; set; }
    }
}
