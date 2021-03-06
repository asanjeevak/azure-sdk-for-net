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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Optional. This object contains status information of the Guest Agent
    /// installed on a RoleInstance. Guest Agent can be installed on a role
    /// instance by setting "ProvisionGuestAgent" to true in Create Deployment
    /// or Add Role API calls. Version header: Required to be "2014-04-01" or
    /// later.
    /// </summary>
    public partial class GuestAgentStatus
    {
        private int? _code;
        
        /// <summary>
        /// Optional. Integer. Status code from the result of applying the GA
        /// settings.
        /// </summary>
        public int? Code
        {
            get { return this._code; }
            set { this._code = value; }
        }
        
        private GuestAgentFormattedMessage _formattedMessage;
        
        /// <summary>
        /// Optional. This object encapsulates localized status message from
        /// the Guest Agent.
        /// </summary>
        public GuestAgentFormattedMessage FormattedMessage
        {
            get { return this._formattedMessage; }
            set { this._formattedMessage = value; }
        }
        
        private string _guestAgentVersion;
        
        /// <summary>
        /// Optional. Version of the Guest Agent installed on the role instance.
        /// </summary>
        public string GuestAgentVersion
        {
            get { return this._guestAgentVersion; }
            set { this._guestAgentVersion = value; }
        }
        
        private GuestAgentMessage _message;
        
        /// <summary>
        /// Optional. This object encapsulates localized status message from
        /// the Guest Agent.
        /// </summary>
        public GuestAgentMessage Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        private string _protocolVersion;
        
        /// <summary>
        /// Optional. Protocol version used by the Guest Agent for status
        /// reporting.
        /// </summary>
        public string ProtocolVersion
        {
            get { return this._protocolVersion; }
            set { this._protocolVersion = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. The guest agent status, which can be: "Ready" or
        /// "NotReady"
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private System.DateTime? _timestamp;
        
        /// <summary>
        /// Optional. UTC time at which the status was reported.
        /// </summary>
        public System.DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GuestAgentStatus class.
        /// </summary>
        public GuestAgentStatus()
        {
        }
    }
}
