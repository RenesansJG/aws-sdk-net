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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
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
namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDevicePolicyConfiguration operation.
    /// Updates the device policy configuration for the fleet.
    /// </summary>
    public partial class UpdateDevicePolicyConfigurationRequest : AmazonWorkLinkRequest
    {
        private string _deviceCaCertificate;
        private string _fleetArn;

        /// <summary>
        /// Gets and sets the property DeviceCaCertificate. 
        /// <para>
        /// The certificate chain, including intermediate certificates and the root certificate
        /// authority certificate used to issue device certificates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32768)]
        public string DeviceCaCertificate
        {
            get { return this._deviceCaCertificate; }
            set { this._deviceCaCertificate = value; }
        }

        // Check to see if DeviceCaCertificate property is set
        internal bool IsSetDeviceCaCertificate()
        {
            return this._deviceCaCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The ARN of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

    }
}