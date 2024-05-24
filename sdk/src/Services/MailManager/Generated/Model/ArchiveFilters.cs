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
    /// A set of filter conditions to include and/or exclude emails.
    /// </summary>
    public partial class ArchiveFilters
    {
        private List<ArchiveFilterCondition> _include = AWSConfigs.InitializeCollections ? new List<ArchiveFilterCondition>() : null;
        private List<ArchiveFilterCondition> _unless = AWSConfigs.InitializeCollections ? new List<ArchiveFilterCondition>() : null;

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// The filter conditions for emails to include.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ArchiveFilterCondition> Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null && (this._include.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Unless. 
        /// <para>
        /// The filter conditions for emails to exclude.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ArchiveFilterCondition> Unless
        {
            get { return this._unless; }
            set { this._unless = value; }
        }

        // Check to see if Unless property is set
        internal bool IsSetUnless()
        {
            return this._unless != null && (this._unless.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}