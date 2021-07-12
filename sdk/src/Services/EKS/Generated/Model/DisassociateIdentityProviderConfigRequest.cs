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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateIdentityProviderConfig operation.
    /// Disassociates an identity provider configuration from a cluster. If you disassociate
    /// an identity provider from your cluster, users included in the provider can no longer
    /// access the cluster. However, you can still access the cluster with Amazon Web Services
    /// IAM users.
    /// </summary>
    public partial class DisassociateIdentityProviderConfigRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _clusterName;
        private IdentityProviderConfig _identityProviderConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster to disassociate an identity provider from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderConfig. 
        /// <para>
        /// An object that represents an identity provider configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentityProviderConfig IdentityProviderConfig
        {
            get { return this._identityProviderConfig; }
            set { this._identityProviderConfig = value; }
        }

        // Check to see if IdentityProviderConfig property is set
        internal bool IsSetIdentityProviderConfig()
        {
            return this._identityProviderConfig != null;
        }

    }
}