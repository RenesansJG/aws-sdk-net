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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SegmentationDescriptor Object
    /// </summary>  
    public class SegmentationDescriptorUnmarshaller : IUnmarshaller<SegmentationDescriptor, XmlUnmarshallerContext>, IUnmarshaller<SegmentationDescriptor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SegmentationDescriptor IUnmarshaller<SegmentationDescriptor, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SegmentationDescriptor Unmarshall(JsonUnmarshallerContext context)
        {
            SegmentationDescriptor unmarshalledObject = new SegmentationDescriptor();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("SegmentationEventId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SegmentationEventId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SegmentationTypeId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SegmentationTypeId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SegmentationUpid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentationUpid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SegmentationUpidType", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SegmentationUpidType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SegmentNum", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SegmentNum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SegmentsExpected", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SegmentsExpected = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubSegmentNum", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SubSegmentNum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubSegmentsExpected", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SubSegmentsExpected = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SegmentationDescriptorUnmarshaller _instance = new SegmentationDescriptorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SegmentationDescriptorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}