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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the ListGatewayInstances operation.
    /// Displays a list of instances associated with the AWS account. This request returns
    /// a paginated result. You can use the filterArn property to display only the instances
    /// associated with the selected Gateway Amazon Resource Name (ARN).
    /// </summary>
    public partial class ListGatewayInstancesRequest : AmazonMediaConnectRequest
    {
        private string _filterArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FilterArn. Filter the list results to display only the
        /// instances associated with the selected Gateway Amazon Resource Name (ARN).
        /// </summary>
        public string FilterArn
        {
            get { return this._filterArn; }
            set { this._filterArn = value; }
        }

        // Check to see if FilterArn property is set
        internal bool IsSetFilterArn()
        {
            return this._filterArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. The maximum number of results to return per
        /// API request. For example, you submit a ListInstances request with MaxResults set at
        /// 5. Although 20 items match your request, the service returns no more than the first
        /// 5 items. (The service also returns a NextToken value that you can use to fetch the
        /// next batch of results.) The service might return fewer results than the MaxResults
        /// value. If MaxResults is not included in the request, the service defaults to pagination
        /// with a maximum of 10 results per page.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. The token that identifies which batch of results
        /// that you want to see. For example, you submit a ListInstances request with MaxResults
        /// set at 5. The service returns the first batch of results (up to 5) and a NextToken
        /// value. To see the next batch of results, you can submit the ListInstances request
        /// a second time and specify the NextToken value.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}