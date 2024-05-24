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
    /// A verdict expression is evaluated against verdicts of the email.
    /// </summary>
    public partial class RuleVerdictExpression
    {
        private RuleVerdictToEvaluate _evaluate;
        private RuleVerdictOperator _operator;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Evaluate. 
        /// <para>
        /// The verdict to evaluate in a verdict condition expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleVerdictToEvaluate Evaluate
        {
            get { return this._evaluate; }
            set { this._evaluate = value; }
        }

        // Check to see if Evaluate property is set
        internal bool IsSetEvaluate()
        {
            return this._evaluate != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The matching operator for a verdict condition expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleVerdictOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values to match with the email's verdict using the given operator. For the EQUALS
        /// operator, if multiple values are given, the condition is deemed to match if any of
        /// the given verdicts match that of the email. For the NOT_EQUALS operator, if multiple
        /// values are given, the condition is deemed to match of none of the given verdicts match
        /// the verdict of the email.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}