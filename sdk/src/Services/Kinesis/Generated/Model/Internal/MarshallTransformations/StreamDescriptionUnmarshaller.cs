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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StreamDescription Object
    /// </summary>  
    public class StreamDescriptionUnmarshaller : IUnmarshaller<StreamDescription, XmlUnmarshallerContext>, IUnmarshaller<StreamDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StreamDescription IUnmarshaller<StreamDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public StreamDescription Unmarshall(JsonUnmarshallerContext context)
        {
            StreamDescription unmarshalledObject = new StreamDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EncryptionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnhancedMonitoring", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EnhancedMetrics, EnhancedMetricsUnmarshaller>(EnhancedMetricsUnmarshaller.Instance);
                    unmarshalledObject.EnhancedMonitoring = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HasMoreShards", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.HasMoreShards = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetentionPeriodHours", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RetentionPeriodHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Shards", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Shard, ShardUnmarshaller>(ShardUnmarshaller.Instance);
                    unmarshalledObject.Shards = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StreamARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StreamCreationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StreamCreationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StreamModeDetails", targetDepth))
                {
                    var unmarshaller = StreamModeDetailsUnmarshaller.Instance;
                    unmarshalledObject.StreamModeDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StreamName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StreamStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StreamDescriptionUnmarshaller _instance = new StreamDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StreamDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}