/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// This is the response object from the GetTrafficPolicy operation.
    /// </summary>
    public partial class GetTrafficPolicyResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private AcceptAction _defaultAction;
        private DateTime? _lastUpdatedTimestamp;
        private int? _maxMessageSizeBytes;
        private List<PolicyStatement> _policyStatements = AWSConfigs.InitializeCollections ? new List<PolicyStatement>() : null;
        private string _trafficPolicyArn;
        private string _trafficPolicyId;
        private string _trafficPolicyName;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the traffic policy was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The default action of the traffic policy.
        /// </para>
        /// </summary>
        public AcceptAction DefaultAction
        {
            get { return this._defaultAction; }
            set { this._defaultAction = value; }
        }

        // Check to see if DefaultAction property is set
        internal bool IsSetDefaultAction()
        {
            return this._defaultAction != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The timestamp of when the traffic policy was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp.GetValueOrDefault(); }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxMessageSizeBytes. 
        /// <para>
        /// The maximum message size in bytes of email which is allowed in by this traffic policy—anything
        /// larger will be blocked.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxMessageSizeBytes
        {
            get { return this._maxMessageSizeBytes.GetValueOrDefault(); }
            set { this._maxMessageSizeBytes = value; }
        }

        // Check to see if MaxMessageSizeBytes property is set
        internal bool IsSetMaxMessageSizeBytes()
        {
            return this._maxMessageSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyStatements. 
        /// <para>
        /// The list of conditions which are in the traffic policy resource.
        /// </para>
        /// </summary>
        public List<PolicyStatement> PolicyStatements
        {
            get { return this._policyStatements; }
            set { this._policyStatements = value; }
        }

        // Check to see if PolicyStatements property is set
        internal bool IsSetPolicyStatements()
        {
            return this._policyStatements != null && (this._policyStatements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the traffic policy resource.
        /// </para>
        /// </summary>
        public string TrafficPolicyArn
        {
            get { return this._trafficPolicyArn; }
            set { this._trafficPolicyArn = value; }
        }

        // Check to see if TrafficPolicyArn property is set
        internal bool IsSetTrafficPolicyArn()
        {
            return this._trafficPolicyArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The identifier of the traffic policy resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TrafficPolicyId
        {
            get { return this._trafficPolicyId; }
            set { this._trafficPolicyId = value; }
        }

        // Check to see if TrafficPolicyId property is set
        internal bool IsSetTrafficPolicyId()
        {
            return this._trafficPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyName. 
        /// <para>
        /// A user-friendly name for the traffic policy resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string TrafficPolicyName
        {
            get { return this._trafficPolicyName; }
            set { this._trafficPolicyName = value; }
        }

        // Check to see if TrafficPolicyName property is set
        internal bool IsSetTrafficPolicyName()
        {
            return this._trafficPolicyName != null;
        }

    }
}