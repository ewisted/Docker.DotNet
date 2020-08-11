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
    public class BlkioStats // (types.BlkioStats)
    {
#if NETSTANDARD2_1
        [JsonPropertyName("io_service_bytes_recursive")]
#else
        [DataMember(Name = "io_service_bytes_recursive", EmitDefaultValue = false)]
#endif
        public IList<BlkioStatEntry> IoServiceBytesRecursive { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("io_serviced_recursive")]
#else
        [DataMember(Name = "io_serviced_recursive", EmitDefaultValue = false)]
#endif
        public IList<BlkioStatEntry> IoServicedRecursive { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("io_queue_recursive")]
#else
        [DataMember(Name = "io_queue_recursive", EmitDefaultValue = false)]
#endif
        public IList<BlkioStatEntry> IoQueuedRecursive { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("io_service_time_recursive")]
#else
        [DataMember(Name = "io_service_time_recursive", EmitDefaultValue = false)]
#endif
        public IList<BlkioStatEntry> IoServiceTimeRecursive { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("io_wait_time_recursive")]
#else
        [DataMember(Name = "io_wait_time_recursive", EmitDefaultValue = false)]
#endif
        public IList<BlkioStatEntry> IoWaitTimeRecursive { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("io_merged_recursive")]
#else
        [DataMember(Name = "io_merged_recursive", EmitDefaultValue = false)]
#endif
        public IList<BlkioStatEntry> IoMergedRecursive { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("io_time_recursive")]
#else
        [DataMember(Name = "io_time_recursive", EmitDefaultValue = false)]
#endif
        public IList<BlkioStatEntry> IoTimeRecursive { get; set; }

#if NETSTANDARD2_1
        [JsonPropertyName("sectors_recursive")]
#else
        [DataMember(Name = "sectors_recursive", EmitDefaultValue = false)]
#endif
        public IList<BlkioStatEntry> SectorsRecursive { get; set; }
    }
}
