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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateExportTask Request Marshaller
    /// </summary>       
    public class CreateExportTaskRequestMarshaller : IMarshaller<IRequest, CreateExportTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateExportTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateExportTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            string target = "Logs_20140328.CreateExportTask";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestination())
                {
                    context.Writer.WritePropertyName("destination");
                    context.Writer.Write(publicRequest.Destination);
                }

                if(publicRequest.IsSetDestinationPrefix())
                {
                    context.Writer.WritePropertyName("destinationPrefix");
                    context.Writer.Write(publicRequest.DestinationPrefix);
                }

                if(publicRequest.IsSetFrom())
                {
                    context.Writer.WritePropertyName("from");
                    context.Writer.Write(publicRequest.From);
                }

                if(publicRequest.IsSetLogGroupName())
                {
                    context.Writer.WritePropertyName("logGroupName");
                    context.Writer.Write(publicRequest.LogGroupName);
                }

                if(publicRequest.IsSetLogStreamNamePrefix())
                {
                    context.Writer.WritePropertyName("logStreamNamePrefix");
                    context.Writer.Write(publicRequest.LogStreamNamePrefix);
                }

                if(publicRequest.IsSetTaskName())
                {
                    context.Writer.WritePropertyName("taskName");
                    context.Writer.Write(publicRequest.TaskName);
                }

                if(publicRequest.IsSetTo())
                {
                    context.Writer.WritePropertyName("to");
                    context.Writer.Write(publicRequest.To);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateExportTaskRequestMarshaller _instance = new CreateExportTaskRequestMarshaller();        

        internal static CreateExportTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateExportTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}