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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConformancePackEvaluationResult Object
    /// </summary>  
    public class ConformancePackEvaluationResultUnmarshaller : IUnmarshaller<ConformancePackEvaluationResult, XmlUnmarshallerContext>, IUnmarshaller<ConformancePackEvaluationResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConformancePackEvaluationResult IUnmarshaller<ConformancePackEvaluationResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ConformancePackEvaluationResult Unmarshall(JsonUnmarshallerContext context)
        {
            ConformancePackEvaluationResult unmarshalledObject = new ConformancePackEvaluationResult();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Annotation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Annotation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComplianceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComplianceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfigRuleInvokedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ConfigRuleInvokedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationResultIdentifier", targetDepth))
                {
                    var unmarshaller = EvaluationResultIdentifierUnmarshaller.Instance;
                    unmarshalledObject.EvaluationResultIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultRecordedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ResultRecordedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConformancePackEvaluationResultUnmarshaller _instance = new ConformancePackEvaluationResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConformancePackEvaluationResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}