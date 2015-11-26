// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.RecoveryServices.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    /// <summary>
    /// The response model for the Replication Usgaes.
    /// </summary>
    public partial class ReplicationUsages
    {
        private JobsSummary _jobsSummary;
        
        /// <summary>
        /// Optional. The value for the jobs summary.
        /// </summary>
        public JobsSummary JobsSummary
        {
            get { return this._jobsSummary; }
            set { this._jobsSummary = value; }
        }
        
        private MonitoringSummary _monitoringSummary;
        
        /// <summary>
        /// Optional. The value for the monitoring summary
        /// </summary>
        public MonitoringSummary MonitoringSummary
        {
            get { return this._monitoringSummary; }
            set { this._monitoringSummary = value; }
        }
        
        private int _protectedItemCount;
        
        /// <summary>
        /// Optional. The protected item count.
        /// </summary>
        public int ProtectedItemCount
        {
            get { return this._protectedItemCount; }
            set { this._protectedItemCount = value; }
        }
        
        private int _recoveryPlanCount;
        
        /// <summary>
        /// Optional. The recovery plan count.
        /// </summary>
        public int RecoveryPlanCount
        {
            get { return this._recoveryPlanCount; }
            set { this._recoveryPlanCount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ReplicationUsages class.
        /// </summary>
        public ReplicationUsages()
        {
        }
    }
}
