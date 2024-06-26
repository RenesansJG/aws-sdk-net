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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCustomVerificationEmailTemplate Request Marshaller
    /// </summary>       
    public class UpdateCustomVerificationEmailTemplateRequestMarshaller : IMarshaller<IRequest, UpdateCustomVerificationEmailTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCustomVerificationEmailTemplateRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCustomVerificationEmailTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "UpdateCustomVerificationEmailTemplate");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetFailureRedirectionURL())
                {
                    request.Parameters.Add("FailureRedirectionURL", StringUtils.FromString(publicRequest.FailureRedirectionURL));
                }
                if(publicRequest.IsSetFromEmailAddress())
                {
                    request.Parameters.Add("FromEmailAddress", StringUtils.FromString(publicRequest.FromEmailAddress));
                }
                if(publicRequest.IsSetSuccessRedirectionURL())
                {
                    request.Parameters.Add("SuccessRedirectionURL", StringUtils.FromString(publicRequest.SuccessRedirectionURL));
                }
                if(publicRequest.IsSetTemplateContent())
                {
                    request.Parameters.Add("TemplateContent", StringUtils.FromString(publicRequest.TemplateContent));
                }
                if(publicRequest.IsSetTemplateName())
                {
                    request.Parameters.Add("TemplateName", StringUtils.FromString(publicRequest.TemplateName));
                }
                if(publicRequest.IsSetTemplateSubject())
                {
                    request.Parameters.Add("TemplateSubject", StringUtils.FromString(publicRequest.TemplateSubject));
                }
            }
            return request;
        }
                    private static UpdateCustomVerificationEmailTemplateRequestMarshaller _instance = new UpdateCustomVerificationEmailTemplateRequestMarshaller();        

        internal static UpdateCustomVerificationEmailTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCustomVerificationEmailTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}