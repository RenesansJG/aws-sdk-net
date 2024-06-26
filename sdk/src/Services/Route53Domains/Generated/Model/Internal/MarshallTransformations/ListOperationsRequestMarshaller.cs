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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Domains.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListOperations Request Marshaller
    /// </summary>       
    public class ListOperationsRequestMarshaller : IMarshaller<IRequest, ListOperationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListOperationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListOperationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53Domains");
            string target = "Route53Domains_v20140515.ListOperations";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-05-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMarker())
                {
                    context.Writer.WritePropertyName("Marker");
                    context.Writer.Write(publicRequest.Marker);
                }

                if(publicRequest.IsSetMaxItems())
                {
                    context.Writer.WritePropertyName("MaxItems");
                    context.Writer.Write(publicRequest.MaxItems);
                }

                if(publicRequest.IsSetSortBy())
                {
                    context.Writer.WritePropertyName("SortBy");
                    context.Writer.Write(publicRequest.SortBy);
                }

                if(publicRequest.IsSetSortOrder())
                {
                    context.Writer.WritePropertyName("SortOrder");
                    context.Writer.Write(publicRequest.SortOrder);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStatusListValue in publicRequest.Status)
                    {
                            context.Writer.Write(publicRequestStatusListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSubmittedSince())
                {
                    context.Writer.WritePropertyName("SubmittedSince");
                    context.Writer.Write(publicRequest.SubmittedSince);
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("Type");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTypeListValue in publicRequest.Type)
                    {
                            context.Writer.Write(publicRequestTypeListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListOperationsRequestMarshaller _instance = new ListOperationsRequestMarshaller();        

        internal static ListOperationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListOperationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}