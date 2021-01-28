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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecipes operation.
    /// Lists all of the DataBrew recipes that are defined.
    /// </summary>
    public partial class ListRecipesRequest : AmazonGlueDataBrewRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _recipeVersion;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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

        /// <summary>
        /// Gets and sets the property RecipeVersion. 
        /// <para>
        /// Return only those recipes with a version identifier of <code>LATEST_WORKING</code>
        /// or <code>LATEST_PUBLISHED</code>. If <code>RecipeVersion</code> is omitted, <code>ListRecipes</code>
        /// returns all of the <code>LATEST_PUBLISHED</code> recipe versions.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>LATEST_WORKING</code> | <code>LATEST_PUBLISHED</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public string RecipeVersion
        {
            get { return this._recipeVersion; }
            set { this._recipeVersion = value; }
        }

        // Check to see if RecipeVersion property is set
        internal bool IsSetRecipeVersion()
        {
            return this._recipeVersion != null;
        }

    }
}