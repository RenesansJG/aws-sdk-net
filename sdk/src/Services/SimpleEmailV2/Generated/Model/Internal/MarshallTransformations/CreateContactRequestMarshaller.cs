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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateContact Request Marshaller
    /// </summary>       
    public class CreateContactRequestMarshaller : IMarshaller<IRequest, CreateContactRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateContactRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateContactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetContactListName())
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field ContactListName set");
            request.AddPathResource("{ContactListName}", StringUtils.FromString(publicRequest.ContactListName));
            request.ResourcePath = "/v2/email/contact-lists/{ContactListName}/contacts";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributesData())
                {
                    context.Writer.WritePropertyName("AttributesData");
                    context.Writer.Write(publicRequest.AttributesData);
                }

                if(publicRequest.IsSetEmailAddress())
                {
                    context.Writer.WritePropertyName("EmailAddress");
                    context.Writer.Write(publicRequest.EmailAddress);
                }

                if(publicRequest.IsSetTopicPreferences())
                {
                    context.Writer.WritePropertyName("TopicPreferences");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTopicPreferencesListValue in publicRequest.TopicPreferences)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TopicPreferenceMarshaller.Instance;
                        marshaller.Marshall(publicRequestTopicPreferencesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUnsubscribeAll())
                {
                    context.Writer.WritePropertyName("UnsubscribeAll");
                    context.Writer.Write(publicRequest.UnsubscribeAll);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateContactRequestMarshaller _instance = new CreateContactRequestMarshaller();        

        internal static CreateContactRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateContactRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}