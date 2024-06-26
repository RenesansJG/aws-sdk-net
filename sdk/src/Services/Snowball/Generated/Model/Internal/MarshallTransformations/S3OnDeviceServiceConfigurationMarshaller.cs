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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3OnDeviceServiceConfiguration Marshaller
    /// </summary>
    public class S3OnDeviceServiceConfigurationMarshaller : IRequestMarshaller<S3OnDeviceServiceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3OnDeviceServiceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFaultTolerance())
            {
                context.Writer.WritePropertyName("FaultTolerance");
                context.Writer.Write(requestObject.FaultTolerance);
            }

            if(requestObject.IsSetServiceSize())
            {
                context.Writer.WritePropertyName("ServiceSize");
                context.Writer.Write(requestObject.ServiceSize);
            }

            if(requestObject.IsSetStorageLimit())
            {
                context.Writer.WritePropertyName("StorageLimit");
                if(StringUtils.IsSpecialDoubleValue(requestObject.StorageLimit))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.StorageLimit));
                }
                else
                {
                    context.Writer.Write(requestObject.StorageLimit);
                }
            }

            if(requestObject.IsSetStorageUnit())
            {
                context.Writer.WritePropertyName("StorageUnit");
                context.Writer.Write(requestObject.StorageUnit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3OnDeviceServiceConfigurationMarshaller Instance = new S3OnDeviceServiceConfigurationMarshaller();

    }
}