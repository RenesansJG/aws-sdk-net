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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Polly.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Polly.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EngineNotSupportedException Object
    /// </summary>  
    public class EngineNotSupportedExceptionUnmarshaller : IErrorResponseUnmarshaller<EngineNotSupportedException, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EngineNotSupportedException Unmarshall(JsonUnmarshallerContext context)
        {
            return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse());
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="errorResponse"></param>
        /// <returns></returns>
        public EngineNotSupportedException Unmarshall(JsonUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)
        {
            context.Read();

            EngineNotSupportedException unmarshalledObject = new EngineNotSupportedException(errorResponse.Message, errorResponse.InnerException,
                errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
            }
          
            return unmarshalledObject;
        }

        private static EngineNotSupportedExceptionUnmarshaller _instance = new EngineNotSupportedExceptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EngineNotSupportedExceptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}