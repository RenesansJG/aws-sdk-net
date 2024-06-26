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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// Summary of the membership details of an <c>AppInstanceUser</c>.
    /// </summary>
    public partial class AppInstanceUserMembershipSummary
    {
        private DateTime? _readMarkerTimestamp;
        private ChannelMembershipType _type;

        /// <summary>
        /// Gets and sets the property ReadMarkerTimestamp. 
        /// <para>
        /// The time at which a message was last read.
        /// </para>
        /// </summary>
        public DateTime ReadMarkerTimestamp
        {
            get { return this._readMarkerTimestamp.GetValueOrDefault(); }
            set { this._readMarkerTimestamp = value; }
        }

        // Check to see if ReadMarkerTimestamp property is set
        internal bool IsSetReadMarkerTimestamp()
        {
            return this._readMarkerTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of <c>ChannelMembership</c>.
        /// </para>
        /// </summary>
        public ChannelMembershipType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}