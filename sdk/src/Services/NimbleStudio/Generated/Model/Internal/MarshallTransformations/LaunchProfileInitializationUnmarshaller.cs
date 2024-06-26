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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LaunchProfileInitialization Object
    /// </summary>  
    public class LaunchProfileInitializationUnmarshaller : IUnmarshaller<LaunchProfileInitialization, XmlUnmarshallerContext>, IUnmarshaller<LaunchProfileInitialization, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LaunchProfileInitialization IUnmarshaller<LaunchProfileInitialization, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LaunchProfileInitialization Unmarshall(JsonUnmarshallerContext context)
        {
            LaunchProfileInitialization unmarshalledObject = new LaunchProfileInitialization();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("activeDirectory", targetDepth))
                {
                    var unmarshaller = LaunchProfileInitializationActiveDirectoryUnmarshaller.Instance;
                    unmarshalledObject.ActiveDirectory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2SecurityGroupIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Ec2SecurityGroupIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchProfileId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchProfileId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchProfileProtocolVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchProfileProtocolVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchPurpose", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchPurpose = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platform", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("systemInitializationScripts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LaunchProfileInitializationScript, LaunchProfileInitializationScriptUnmarshaller>(LaunchProfileInitializationScriptUnmarshaller.Instance);
                    unmarshalledObject.SystemInitializationScripts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userInitializationScripts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LaunchProfileInitializationScript, LaunchProfileInitializationScriptUnmarshaller>(LaunchProfileInitializationScriptUnmarshaller.Instance);
                    unmarshalledObject.UserInitializationScripts = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LaunchProfileInitializationUnmarshaller _instance = new LaunchProfileInitializationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LaunchProfileInitializationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}