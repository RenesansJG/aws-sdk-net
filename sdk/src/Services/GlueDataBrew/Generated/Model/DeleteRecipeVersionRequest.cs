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
    /// Container for the parameters to the DeleteRecipeVersion operation.
    /// Deletes a single version of a DataBrew recipe.
    /// </summary>
    public partial class DeleteRecipeVersionRequest : AmazonGlueDataBrewRequest
    {
        private string _name;
        private string _recipeVersion;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeVersion. 
        /// <para>
        /// The version of the recipe to be deleted. You can specify a numeric versions (<code>X.Y</code>)
        /// or <code>LATEST_WORKING</code>. <code>LATEST_PUBLISHED</code> is not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
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