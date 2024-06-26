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
 * Do not modify this file. This file is generated from the iot1click-devices-2018-05-14.normal.json service model.
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
namespace Amazon.IoT1ClickDevicesService.Model
{
    /// <summary>
    /// Container for the parameters to the InitiateDeviceClaim operation.
    /// Given a device ID, initiates a claim request for the associated device.
    /// 
    /// <note> 
    /// <para>
    /// Claiming a device consists of initiating a claim, then publishing a device event,
    /// and finalizing the claim. For a device of type button, a device event can be published
    /// by simply clicking the device.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InitiateDeviceClaimRequest : AmazonIoT1ClickDevicesServiceRequest
    {
        private string _deviceId;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The unique identifier of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

    }
}