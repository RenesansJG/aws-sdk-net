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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains the output of PurchaseScheduledInstances.
    /// </summary>
    public partial class PurchaseScheduledInstancesResponse : AmazonWebServiceResponse
    {
        private List<ScheduledInstance> _scheduledInstanceSet = AWSConfigs.InitializeCollections ? new List<ScheduledInstance>() : null;

        /// <summary>
        /// Gets and sets the property ScheduledInstanceSet. 
        /// <para>
        /// Information about the Scheduled Instances.
        /// </para>
        /// </summary>
        public List<ScheduledInstance> ScheduledInstanceSet
        {
            get { return this._scheduledInstanceSet; }
            set { this._scheduledInstanceSet = value; }
        }

        // Check to see if ScheduledInstanceSet property is set
        internal bool IsSetScheduledInstanceSet()
        {
            return this._scheduledInstanceSet != null && (this._scheduledInstanceSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}