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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the GetCachePolicy operation.
    /// Gets a cache policy, including the following metadata:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The policy's identifier.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The date and time when the policy was last modified.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get a cache policy, you must provide the policy's identifier. If the cache policy
    /// is attached to a distribution's cache behavior, you can get the policy's identifier
    /// using <c>ListDistributions</c> or <c>GetDistribution</c>. If the cache policy is not
    /// attached to a cache behavior, you can get the identifier using <c>ListCachePolicies</c>.
    /// </para>
    /// </summary>
    public partial class GetCachePolicyRequest : AmazonCloudFrontRequest
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the cache policy. If the cache policy is attached to a distribution's
        /// cache behavior, you can get the policy's identifier using <c>ListDistributions</c>
        /// or <c>GetDistribution</c>. If the cache policy is not attached to a cache behavior,
        /// you can get the identifier using <c>ListCachePolicies</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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