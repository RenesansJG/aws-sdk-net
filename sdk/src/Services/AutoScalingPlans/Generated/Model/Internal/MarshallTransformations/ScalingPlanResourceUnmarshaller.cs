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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScalingPlans.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScalingPlans.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScalingPlanResource Object
    /// </summary>  
    public class ScalingPlanResourceUnmarshaller : IUnmarshaller<ScalingPlanResource, XmlUnmarshallerContext>, IUnmarshaller<ScalingPlanResource, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ScalingPlanResource IUnmarshaller<ScalingPlanResource, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ScalingPlanResource Unmarshall(JsonUnmarshallerContext context)
        {
            ScalingPlanResource unmarshalledObject = new ScalingPlanResource();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ResourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScalableDimension", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScalableDimension = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScalingPlanName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScalingPlanName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScalingPlanVersion", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ScalingPlanVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScalingPolicies", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ScalingPolicy, ScalingPolicyUnmarshaller>(ScalingPolicyUnmarshaller.Instance);
                    unmarshalledObject.ScalingPolicies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScalingStatusCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScalingStatusCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScalingStatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScalingStatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceNamespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceNamespace = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ScalingPlanResourceUnmarshaller _instance = new ScalingPlanResourceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScalingPlanResourceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}