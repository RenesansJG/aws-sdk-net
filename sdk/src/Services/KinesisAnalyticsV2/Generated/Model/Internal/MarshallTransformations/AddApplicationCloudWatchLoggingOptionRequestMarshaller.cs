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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddApplicationCloudWatchLoggingOption Request Marshaller
    /// </summary>       
    public class AddApplicationCloudWatchLoggingOptionRequestMarshaller : IMarshaller<IRequest, AddApplicationCloudWatchLoggingOptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddApplicationCloudWatchLoggingOptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AddApplicationCloudWatchLoggingOptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisAnalyticsV2");
            string target = "KinesisAnalytics_20180523.AddApplicationCloudWatchLoggingOption";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-23";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationName())
                {
                    context.Writer.WritePropertyName("ApplicationName");
                    context.Writer.Write(publicRequest.ApplicationName);
                }

                if(publicRequest.IsSetCloudWatchLoggingOption())
                {
                    context.Writer.WritePropertyName("CloudWatchLoggingOption");
                    context.Writer.WriteObjectStart();

                    var marshaller = CloudWatchLoggingOptionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CloudWatchLoggingOption, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConditionalToken())
                {
                    context.Writer.WritePropertyName("ConditionalToken");
                    context.Writer.Write(publicRequest.ConditionalToken);
                }

                if(publicRequest.IsSetCurrentApplicationVersionId())
                {
                    context.Writer.WritePropertyName("CurrentApplicationVersionId");
                    context.Writer.Write(publicRequest.CurrentApplicationVersionId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AddApplicationCloudWatchLoggingOptionRequestMarshaller _instance = new AddApplicationCloudWatchLoggingOptionRequestMarshaller();        

        internal static AddApplicationCloudWatchLoggingOptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddApplicationCloudWatchLoggingOptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}