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
    /// This action replaces the email envelope recipients with the given list of recipients.
    /// If the condition of this action applies only to a subset of recipients, only those
    /// recipients are replaced with the recipients specified in the action. The message contents
    /// and headers are unaffected by this action, only the envelope recipients are updated.
    /// </summary>
    public partial class ReplaceRecipientAction
    {
        private List<string> _replaceWith = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ReplaceWith. 
        /// <para>
        /// This action specifies the replacement recipient email addresses to insert.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ReplaceWith
        {
            get { return this._replaceWith; }
            set { this._replaceWith = value; }
        }

        // Check to see if ReplaceWith property is set
        internal bool IsSetReplaceWith()
        {
            return this._replaceWith != null && (this._replaceWith.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}