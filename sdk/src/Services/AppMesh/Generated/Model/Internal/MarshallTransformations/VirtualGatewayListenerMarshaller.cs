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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VirtualGatewayListener Marshaller
    /// </summary>
    public class VirtualGatewayListenerMarshaller : IRequestMarshaller<VirtualGatewayListener, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VirtualGatewayListener requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectionPool())
            {
                context.Writer.WritePropertyName("connectionPool");
                context.Writer.WriteObjectStart();

                var marshaller = VirtualGatewayConnectionPoolMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionPool, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHealthCheck())
            {
                context.Writer.WritePropertyName("healthCheck");
                context.Writer.WriteObjectStart();

                var marshaller = VirtualGatewayHealthCheckPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthCheck, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPortMapping())
            {
                context.Writer.WritePropertyName("portMapping");
                context.Writer.WriteObjectStart();

                var marshaller = VirtualGatewayPortMappingMarshaller.Instance;
                marshaller.Marshall(requestObject.PortMapping, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTls())
            {
                context.Writer.WritePropertyName("tls");
                context.Writer.WriteObjectStart();

                var marshaller = VirtualGatewayListenerTlsMarshaller.Instance;
                marshaller.Marshall(requestObject.Tls, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VirtualGatewayListenerMarshaller Instance = new VirtualGatewayListenerMarshaller();

    }
}