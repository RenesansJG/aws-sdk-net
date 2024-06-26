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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SchemaAttributeType Object
    /// </summary>  
    public class SchemaAttributeTypeUnmarshaller : IUnmarshaller<SchemaAttributeType, XmlUnmarshallerContext>, IUnmarshaller<SchemaAttributeType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SchemaAttributeType IUnmarshaller<SchemaAttributeType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SchemaAttributeType Unmarshall(JsonUnmarshallerContext context)
        {
            SchemaAttributeType unmarshalledObject = new SchemaAttributeType();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AttributeDataType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AttributeDataType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeveloperOnlyAttribute", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DeveloperOnlyAttribute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Mutable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Mutable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberAttributeConstraints", targetDepth))
                {
                    var unmarshaller = NumberAttributeConstraintsTypeUnmarshaller.Instance;
                    unmarshalledObject.NumberAttributeConstraints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Required", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Required = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StringAttributeConstraints", targetDepth))
                {
                    var unmarshaller = StringAttributeConstraintsTypeUnmarshaller.Instance;
                    unmarshalledObject.StringAttributeConstraints = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SchemaAttributeTypeUnmarshaller _instance = new SchemaAttributeTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SchemaAttributeTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}