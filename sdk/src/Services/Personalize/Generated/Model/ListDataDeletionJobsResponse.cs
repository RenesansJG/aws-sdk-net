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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// This is the response object from the ListDataDeletionJobs operation.
    /// </summary>
    public partial class ListDataDeletionJobsResponse : AmazonWebServiceResponse
    {
        private List<DataDeletionJobSummary> _dataDeletionJobs = AWSConfigs.InitializeCollections ? new List<DataDeletionJobSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DataDeletionJobs. 
        /// <para>
        /// The list of data deletion jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<DataDeletionJobSummary> DataDeletionJobs
        {
            get { return this._dataDeletionJobs; }
            set { this._dataDeletionJobs = value; }
        }

        // Check to see if DataDeletionJobs property is set
        internal bool IsSetDataDeletionJobs()
        {
            return this._dataDeletionJobs != null && (this._dataDeletionJobs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token for getting the next set of data deletion jobs (if they exist).
        /// </para>
        /// </summary>
        [AWSProperty(Max=1500)]
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