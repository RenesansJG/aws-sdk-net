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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// If this contact was queued, this contains information about the queue.
    /// </summary>
    public partial class QueueInfo
    {
        private DateTime? _enqueueTimestamp;
        private string _id;

        /// <summary>
        /// Gets and sets the property EnqueueTimestamp. 
        /// <para>
        /// The timestamp when the contact was added to the queue.
        /// </para>
        /// </summary>
        public DateTime EnqueueTimestamp
        {
            get { return this._enqueueTimestamp.GetValueOrDefault(); }
            set { this._enqueueTimestamp = value; }
        }

        // Check to see if EnqueueTimestamp property is set
        internal bool IsSetEnqueueTimestamp()
        {
            return this._enqueueTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the agent who accepted the contact.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}