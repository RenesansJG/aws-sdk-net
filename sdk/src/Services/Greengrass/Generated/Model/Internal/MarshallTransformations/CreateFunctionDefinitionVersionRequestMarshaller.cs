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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFunctionDefinitionVersion Request Marshaller
    /// </summary>       
    public class CreateFunctionDefinitionVersionRequestMarshaller : IMarshaller<IRequest, CreateFunctionDefinitionVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFunctionDefinitionVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFunctionDefinitionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-06-07";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetFunctionDefinitionId())
                throw new AmazonGreengrassException("Request object does not have required field FunctionDefinitionId set");
            request.AddPathResource("{FunctionDefinitionId}", StringUtils.FromString(publicRequest.FunctionDefinitionId));
            request.ResourcePath = "/greengrass/definition/functions/{FunctionDefinitionId}/versions";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefaultConfig())
                {
                    context.Writer.WritePropertyName("DefaultConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = FunctionDefaultConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DefaultConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFunctions())
                {
                    context.Writer.WritePropertyName("Functions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFunctionsListValue in publicRequest.Functions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = FunctionMarshaller.Instance;
                        marshaller.Marshall(publicRequestFunctionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetAmznClientToken()) 
            {
                request.Headers["X-Amzn-Client-Token"] = publicRequest.AmznClientToken;
            }

            return request;
        }
        private static CreateFunctionDefinitionVersionRequestMarshaller _instance = new CreateFunctionDefinitionVersionRequestMarshaller();        

        internal static CreateFunctionDefinitionVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFunctionDefinitionVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}