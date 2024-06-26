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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticFileSystem.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutFileSystemPolicy Request Marshaller
    /// </summary>       
    public class PutFileSystemPolicyRequestMarshaller : IMarshaller<IRequest, PutFileSystemPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutFileSystemPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutFileSystemPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticFileSystem");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-02-01";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFileSystemId())
                throw new AmazonElasticFileSystemException("Request object does not have required field FileSystemId set");
            request.AddPathResource("{FileSystemId}", StringUtils.FromString(publicRequest.FileSystemId));
            request.ResourcePath = "/2015-02-01/file-systems/{FileSystemId}/policy";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBypassPolicyLockoutSafetyCheck())
                {
                    context.Writer.WritePropertyName("BypassPolicyLockoutSafetyCheck");
                    context.Writer.Write(publicRequest.BypassPolicyLockoutSafetyCheck);
                }

                if(publicRequest.IsSetPolicy())
                {
                    context.Writer.WritePropertyName("Policy");
                    context.Writer.Write(publicRequest.Policy);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutFileSystemPolicyRequestMarshaller _instance = new PutFileSystemPolicyRequestMarshaller();        

        internal static PutFileSystemPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutFileSystemPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}