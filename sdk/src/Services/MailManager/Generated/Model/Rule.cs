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
    /// A rule contains conditions, "unless conditions" and actions. For each envelope recipient
    /// of an email, if all conditions match and none of the "unless conditions" match, then
    /// all of the actions are executed sequentially. If no conditions are provided, the rule
    /// always applies and the actions are implicitly executed. If only "unless conditions"
    /// are provided, the rule applies if the email does not match the evaluation of the "unless
    /// conditions".
    /// </summary>
    public partial class Rule
    {
        private List<RuleAction> _actions = AWSConfigs.InitializeCollections ? new List<RuleAction>() : null;
        private List<RuleCondition> _conditions = AWSConfigs.InitializeCollections ? new List<RuleCondition>() : null;
        private string _name;
        private List<RuleCondition> _unless = AWSConfigs.InitializeCollections ? new List<RuleCondition>() : null;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The list of actions to execute when the conditions match the incoming email, and none
        /// of the "unless conditions" match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<RuleAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// The conditions of this rule. All conditions must match the email for the actions to
        /// be executed. An empty list of conditions means that all emails match, but are still
        /// subject to any "unless conditions"
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<RuleCondition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && (this._conditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user-friendly name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// Gets and sets the property Unless. 
        /// <para>
        /// The "unless conditions" of this rule. None of the conditions can match the email for
        /// the actions to be executed. If any of these conditions do match the email, then the
        /// actions are not executed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<RuleCondition> Unless
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