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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGameSessionQueue Request Marshaller
    /// </summary>       
    public class CreateGameSessionQueueRequestMarshaller : IMarshaller<IRequest, CreateGameSessionQueueRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGameSessionQueueRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGameSessionQueueRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.CreateGameSessionQueue";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCustomEventData())
                {
                    context.Writer.WritePropertyName("CustomEventData");
                    context.Writer.Write(publicRequest.CustomEventData);
                }

                if(publicRequest.IsSetDestinations())
                {
                    context.Writer.WritePropertyName("Destinations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDestinationsListValue in publicRequest.Destinations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = GameSessionQueueDestinationMarshaller.Instance;
                        marshaller.Marshall(publicRequestDestinationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFilterConfiguration())
                {
                    context.Writer.WritePropertyName("FilterConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = FilterConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FilterConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNotificationTarget())
                {
                    context.Writer.WritePropertyName("NotificationTarget");
                    context.Writer.Write(publicRequest.NotificationTarget);
                }

                if(publicRequest.IsSetPlayerLatencyPolicies())
                {
                    context.Writer.WritePropertyName("PlayerLatencyPolicies");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPlayerLatencyPoliciesListValue in publicRequest.PlayerLatencyPolicies)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PlayerLatencyPolicyMarshaller.Instance;
                        marshaller.Marshall(publicRequestPlayerLatencyPoliciesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPriorityConfiguration())
                {
                    context.Writer.WritePropertyName("PriorityConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = PriorityConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PriorityConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTimeoutInSeconds())
                {
                    context.Writer.WritePropertyName("TimeoutInSeconds");
                    context.Writer.Write(publicRequest.TimeoutInSeconds);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateGameSessionQueueRequestMarshaller _instance = new CreateGameSessionQueueRequestMarshaller();        

        internal static CreateGameSessionQueueRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGameSessionQueueRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}