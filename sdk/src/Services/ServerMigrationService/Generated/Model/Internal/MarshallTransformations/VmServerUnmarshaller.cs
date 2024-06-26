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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ServerMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VmServer Object
    /// </summary>  
    public class VmServerUnmarshaller : IUnmarshaller<VmServer, XmlUnmarshallerContext>, IUnmarshaller<VmServer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VmServer IUnmarshaller<VmServer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public VmServer Unmarshall(JsonUnmarshallerContext context)
        {
            VmServer unmarshalledObject = new VmServer();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("vmManagerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VmManagerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vmManagerType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VmManagerType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vmName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VmName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vmPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VmPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vmServerAddress", targetDepth))
                {
                    var unmarshaller = VmServerAddressUnmarshaller.Instance;
                    unmarshalledObject.VmServerAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VmServerUnmarshaller _instance = new VmServerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VmServerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}