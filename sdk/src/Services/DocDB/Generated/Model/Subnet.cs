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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Detailed information about a subnet.
    /// </summary>
    public partial class Subnet
    {
        private AvailabilityZone _subnetAvailabilityZone;
        private string _subnetIdentifier;
        private string _subnetStatus;

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZone. 
        /// <para>
        /// Specifies the Availability Zone for the subnet.
        /// </para>
        /// </summary>
        public AvailabilityZone SubnetAvailabilityZone
        {
            get { return this._subnetAvailabilityZone; }
            set { this._subnetAvailabilityZone = value; }
        }

        // Check to see if SubnetAvailabilityZone property is set
        internal bool IsSetSubnetAvailabilityZone()
        {
            return this._subnetAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIdentifier. 
        /// <para>
        /// Specifies the identifier of the subnet.
        /// </para>
        /// </summary>
        public string SubnetIdentifier
        {
            get { return this._subnetIdentifier; }
            set { this._subnetIdentifier = value; }
        }

        // Check to see if SubnetIdentifier property is set
        internal bool IsSetSubnetIdentifier()
        {
            return this._subnetIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetStatus. 
        /// <para>
        /// Specifies the status of the subnet.
        /// </para>
        /// </summary>
        public string SubnetStatus
        {
            get { return this._subnetStatus; }
            set { this._subnetStatus = value; }
        }

        // Check to see if SubnetStatus property is set
        internal bool IsSetSubnetStatus()
        {
            return this._subnetStatus != null;
        }

    }
}