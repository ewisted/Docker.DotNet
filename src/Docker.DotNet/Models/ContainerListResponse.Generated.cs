using System;
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
    public class ContainerListResponse // (types.Container)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("Id")]
#else
        [DataMember(Name = "Id", EmitDefaultValue = false)]
#endif
        public string ID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Names")]
#else
        [DataMember(Name = "Names", EmitDefaultValue = false)]
#endif
        public IList<string> Names { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Image")]
#else
        [DataMember(Name = "Image", EmitDefaultValue = false)]
#endif
        public string Image { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("ImageID")]
#else
        [DataMember(Name = "ImageID", EmitDefaultValue = false)]
#endif
        public string ImageID { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Command")]
#else
        [DataMember(Name = "Command", EmitDefaultValue = false)]
#endif
        public string Command { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Created")]
#else
        [DataMember(Name = "Created", EmitDefaultValue = false)]
#endif
        public DateTime Created { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Ports")]
#else
        [DataMember(Name = "Ports", EmitDefaultValue = false)]
#endif
        public IList<Port> Ports { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SizeRw")]
#else
        [DataMember(Name = "SizeRw", EmitDefaultValue = false)]
#endif
        public long SizeRw { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("SizeRootFs")]
#else
        [DataMember(Name = "SizeRootFs", EmitDefaultValue = false)]
#endif
        public long SizeRootFs { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Labels")]
#else
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
#endif
        public IDictionary<string, string> Labels { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("State")]
#else
        [DataMember(Name = "State", EmitDefaultValue = false)]
#endif
        public string State { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Status")]
#else
        [DataMember(Name = "Status", EmitDefaultValue = false)]
#endif
        public string Status { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("NetworkSettings")]
#else
        [DataMember(Name = "NetworkSettings", EmitDefaultValue = false)]
#endif
        public SummaryNetworkSettings NetworkSettings { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("Mounts")]
#else
        [DataMember(Name = "Mounts", EmitDefaultValue = false)]
#endif
        public IList<MountPoint> Mounts { get; set; }
    }
}
