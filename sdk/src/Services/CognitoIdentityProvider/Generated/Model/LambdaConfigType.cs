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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Specifies the configuration for Lambda triggers.
    /// </summary>
    public partial class LambdaConfigType
    {
        private string _createAuthChallenge;
        private CustomEmailLambdaVersionConfigType _customEmailSender;
        private string _customMessage;
        private CustomSMSLambdaVersionConfigType _customSMSSender;
        private string _defineAuthChallenge;
        private string _kmsKeyID;
        private string _postAuthentication;
        private string _postConfirmation;
        private string _preAuthentication;
        private string _preSignUp;
        private string _preTokenGeneration;
        private PreTokenGenerationVersionConfigType _preTokenGenerationConfig;
        private string _userMigration;
        private string _verifyAuthChallengeResponse;

        /// <summary>
        /// Gets and sets the property CreateAuthChallenge. 
        /// <para>
        /// Creates an authentication challenge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CreateAuthChallenge
        {
            get { return this._createAuthChallenge; }
            set { this._createAuthChallenge = value; }
        }

        // Check to see if CreateAuthChallenge property is set
        internal bool IsSetCreateAuthChallenge()
        {
            return this._createAuthChallenge != null;
        }

        /// <summary>
        /// Gets and sets the property CustomEmailSender. 
        /// <para>
        /// A custom email sender Lambda trigger.
        /// </para>
        /// </summary>
        public CustomEmailLambdaVersionConfigType CustomEmailSender
        {
            get { return this._customEmailSender; }
            set { this._customEmailSender = value; }
        }

        // Check to see if CustomEmailSender property is set
        internal bool IsSetCustomEmailSender()
        {
            return this._customEmailSender != null;
        }

        /// <summary>
        /// Gets and sets the property CustomMessage. 
        /// <para>
        /// A custom Message Lambda trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CustomMessage
        {
            get { return this._customMessage; }
            set { this._customMessage = value; }
        }

        // Check to see if CustomMessage property is set
        internal bool IsSetCustomMessage()
        {
            return this._customMessage != null;
        }

        /// <summary>
        /// Gets and sets the property CustomSMSSender. 
        /// <para>
        /// A custom SMS sender Lambda trigger.
        /// </para>
        /// </summary>
        public CustomSMSLambdaVersionConfigType CustomSMSSender
        {
            get { return this._customSMSSender; }
            set { this._customSMSSender = value; }
        }

        // Check to see if CustomSMSSender property is set
        internal bool IsSetCustomSMSSender()
        {
            return this._customSMSSender != null;
        }

        /// <summary>
        /// Gets and sets the property DefineAuthChallenge. 
        /// <para>
        /// Defines the authentication challenge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DefineAuthChallenge
        {
            get { return this._defineAuthChallenge; }
            set { this._defineAuthChallenge = value; }
        }

        // Check to see if DefineAuthChallenge property is set
        internal bool IsSetDefineAuthChallenge()
        {
            return this._defineAuthChallenge != null;
        }

        /// <summary>
        /// Gets and sets the property KMSKeyID. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an <a href="/kms/latest/developerguide/concepts.html#master_keys">KMS
        /// key</a>. Amazon Cognito uses the key to encrypt codes and temporary passwords sent
        /// to <c>CustomEmailSender</c> and <c>CustomSMSSender</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KMSKeyID
        {
            get { return this._kmsKeyID; }
            set { this._kmsKeyID = value; }
        }

        // Check to see if KMSKeyID property is set
        internal bool IsSetKMSKeyID()
        {
            return this._kmsKeyID != null;
        }

        /// <summary>
        /// Gets and sets the property PostAuthentication. 
        /// <para>
        /// A post-authentication Lambda trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PostAuthentication
        {
            get { return this._postAuthentication; }
            set { this._postAuthentication = value; }
        }

        // Check to see if PostAuthentication property is set
        internal bool IsSetPostAuthentication()
        {
            return this._postAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property PostConfirmation. 
        /// <para>
        /// A post-confirmation Lambda trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PostConfirmation
        {
            get { return this._postConfirmation; }
            set { this._postConfirmation = value; }
        }

        // Check to see if PostConfirmation property is set
        internal bool IsSetPostConfirmation()
        {
            return this._postConfirmation != null;
        }

        /// <summary>
        /// Gets and sets the property PreAuthentication. 
        /// <para>
        /// A pre-authentication Lambda trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PreAuthentication
        {
            get { return this._preAuthentication; }
            set { this._preAuthentication = value; }
        }

        // Check to see if PreAuthentication property is set
        internal bool IsSetPreAuthentication()
        {
            return this._preAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property PreSignUp. 
        /// <para>
        /// A pre-registration Lambda trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PreSignUp
        {
            get { return this._preSignUp; }
            set { this._preSignUp = value; }
        }

        // Check to see if PreSignUp property is set
        internal bool IsSetPreSignUp()
        {
            return this._preSignUp != null;
        }

        /// <summary>
        /// Gets and sets the property PreTokenGeneration. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function that you want to assign to your Lambda
        /// trigger.
        /// </para>
        ///  
        /// <para>
        /// Set this parameter for legacy purposes. If you also set an ARN in <c>PreTokenGenerationConfig</c>,
        /// its value must be identical to <c>PreTokenGeneration</c>. For new instances of pre
        /// token generation triggers, set the <c>LambdaArn</c> of <c>PreTokenGenerationConfig</c>.
        /// </para>
        ///  
        /// <para>
        /// You can set <code/> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PreTokenGeneration
        {
            get { return this._preTokenGeneration; }
            set { this._preTokenGeneration = value; }
        }

        // Check to see if PreTokenGeneration property is set
        internal bool IsSetPreTokenGeneration()
        {
            return this._preTokenGeneration != null;
        }

        /// <summary>
        /// Gets and sets the property PreTokenGenerationConfig. 
        /// <para>
        /// The detailed configuration of a pre token generation trigger. If you also set an ARN
        /// in <c>PreTokenGeneration</c>, its value must be identical to <c>PreTokenGenerationConfig</c>.
        /// </para>
        /// </summary>
        public PreTokenGenerationVersionConfigType PreTokenGenerationConfig
        {
            get { return this._preTokenGenerationConfig; }
            set { this._preTokenGenerationConfig = value; }
        }

        // Check to see if PreTokenGenerationConfig property is set
        internal bool IsSetPreTokenGenerationConfig()
        {
            return this._preTokenGenerationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property UserMigration. 
        /// <para>
        /// The user migration Lambda config type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string UserMigration
        {
            get { return this._userMigration; }
            set { this._userMigration = value; }
        }

        // Check to see if UserMigration property is set
        internal bool IsSetUserMigration()
        {
            return this._userMigration != null;
        }

        /// <summary>
        /// Gets and sets the property VerifyAuthChallengeResponse. 
        /// <para>
        /// Verifies the authentication challenge response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string VerifyAuthChallengeResponse
        {
            get { return this._verifyAuthChallengeResponse; }
            set { this._verifyAuthChallengeResponse = value; }
        }

        // Check to see if VerifyAuthChallengeResponse property is set
        internal bool IsSetVerifyAuthChallengeResponse()
        {
            return this._verifyAuthChallengeResponse != null;
        }

    }
}