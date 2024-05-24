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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Information regarding UpdateBrokerCount.
    /// </summary>
    public partial class BrokerCountUpdateInfo
    {
        private List<double> _createdBrokerIds = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<double> _deletedBrokerIds = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Gets and sets the property CreatedBrokerIds.             
        /// <para>
        /// Kafka Broker IDs of brokers being created.
        /// </para>
        /// </summary>
        public List<double> CreatedBrokerIds
        {
            get { return this._createdBrokerIds; }
            set { this._createdBrokerIds = value; }
        }

        // Check to see if CreatedBrokerIds property is set
        internal bool IsSetCreatedBrokerIds()
        {
            return this._createdBrokerIds != null && (this._createdBrokerIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeletedBrokerIds.             
        /// <para>
        /// Kafka Broker IDs of brokers being deleted.
        /// </para>
        /// </summary>
        public List<double> DeletedBrokerIds
        {
            get { return this._deletedBrokerIds; }
            set { this._deletedBrokerIds = value; }
        }

        // Check to see if DeletedBrokerIds property is set
        internal bool IsSetDeletedBrokerIds()
        {
            return this._deletedBrokerIds != null && (this._deletedBrokerIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}