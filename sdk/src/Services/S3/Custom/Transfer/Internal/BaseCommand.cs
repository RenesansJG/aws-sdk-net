﻿/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Util;

namespace Amazon.S3.Transfer.Internal
{
    internal abstract partial class BaseCommand
    {
#if BCL && !BCL45
        public abstract void Execute();
#endif 

        public virtual object Return
        {
            get { return null; }
        }

        protected GetObjectRequest ConvertToGetObjectRequest(BaseDownloadRequest request)
        {
            GetObjectRequest getRequest = new GetObjectRequest()
            {
                BucketName = request.BucketName,
                Key = request.Key,
                VersionId = request.VersionId
            };
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)getRequest).AddBeforeRequestHandler(this.RequestEventHandler);

            if (request.IsSetModifiedSinceDateUtc())
            {
                getRequest.ModifiedSinceDateUtc = request.ModifiedSinceDateUtc;
            }
            if (request.IsSetUnmodifiedSinceDateUtc())
            {
                getRequest.UnmodifiedSinceDateUtc = request.UnmodifiedSinceDateUtc;
            }

            getRequest.ServerSideEncryptionCustomerMethod = request.ServerSideEncryptionCustomerMethod;
            getRequest.ServerSideEncryptionCustomerProvidedKey = request.ServerSideEncryptionCustomerProvidedKey;
            getRequest.ServerSideEncryptionCustomerProvidedKeyMD5 = request.ServerSideEncryptionCustomerProvidedKeyMD5;
            getRequest.ChecksumMode = request.ChecksumMode;
            getRequest.RequestPayer = request.RequestPayer;

            return getRequest;
        }

        protected void RequestEventHandler(object sender, RequestEventArgs args)
        {
            WebServiceRequestEventArgs wsArgs = args as WebServiceRequestEventArgs;
            if (wsArgs != null)
            {
                string currentUserAgent = wsArgs.Headers[AWSSDKUtils.UserAgentHeader];
                wsArgs.Headers[AWSSDKUtils.UserAgentHeader] =
                    currentUserAgent + " ft/s3-transfer md/" + this.GetType().Name;
            }
        }
    }
}
