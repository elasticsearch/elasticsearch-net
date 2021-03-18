// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗ 
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝ 
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗   
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝   
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗ 
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝ 
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;
using System.Text.Json.Serialization;

namespace Nest
{
    public class DeleteSnapshotLifecycleResponse : AcknowledgedResponseBase
    {
    }

    public class ExecuteSnapshotLifecycleResponse : ResponseBase
    {
        [JsonPropertyName("snapshot_name")]
        public string SnapshotName { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class ExecuteRetentionResponse : AcknowledgedResponseBase
    {
    }

    public class GetSnapshotLifecycleResponse : DictionaryResponseBase
    {
    }

    public class GetSnapshotLifecycleStatsResponse : ResponseBase
    {
        [JsonPropertyName("retention_deletion_time")]
        public string RetentionDeletionTime { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("retention_failed")]
        public long RetentionFailed { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("retention_runs")]
        public long RetentionRuns { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("retention_timed_out")]
        public long RetentionTimedOut { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("total_snapshots_deleted")]
        public long TotalSnapshotsDeleted { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("total_snapshot_deletion_failures")]
        public long TotalSnapshotDeletionFailures { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("total_snapshots_failed")]
        public long TotalSnapshotsFailed { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("total_snapshots_taken")]
        public long TotalSnapshotsTaken { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class GetSnapshotLifecycleManagementStatusResponse : ResponseBase
    {
        [JsonPropertyName("operation_mode")]
        public LifecycleOperationMode OperationMode { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class PutSnapshotLifecycleResponse : AcknowledgedResponseBase
    {
    }

    public class StartSnapshotLifecycleManagementResponse : AcknowledgedResponseBase
    {
    }

    public class StopSnapshotLifecycleManagementResponse : AcknowledgedResponseBase
    {
    }
}