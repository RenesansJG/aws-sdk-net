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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ApplicationPolicy Object
    /// </summary>  
    public class ApplicationPolicyUnmarshaller : IUnmarshaller<ApplicationPolicy, XmlUnmarshallerContext>, IUnmarshaller<ApplicationPolicy, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ApplicationPolicy IUnmarshaller<ApplicationPolicy, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ApplicationPolicy Unmarshall(JsonUnmarshallerContext context)
        {
            ApplicationPolicy unmarshalledObject = new ApplicationPolicy();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("PolicyObjectIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyObjectIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PolicyType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ApplicationPolicyUnmarshaller _instance = new ApplicationPolicyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApplicationPolicyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}