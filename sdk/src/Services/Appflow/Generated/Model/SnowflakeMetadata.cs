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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector metadata specific to Snowflake.
    /// </summary>
    public partial class SnowflakeMetadata
    {
        private List<string> _supportedRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SupportedRegions. 
        /// <para>
        ///  Specifies the supported Amazon Web Services Regions when using Snowflake. 
        /// </para>
        /// </summary>
        public List<string> SupportedRegions
        {
            get { return this._supportedRegions; }
            set { this._supportedRegions = value; }
        }

        // Check to see if SupportedRegions property is set
        internal bool IsSetSupportedRegions()
        {
            return this._supportedRegions != null && (this._supportedRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}