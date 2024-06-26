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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CaptionRectangle Marshaller
    /// </summary>
    public class CaptionRectangleMarshaller : IRequestMarshaller<CaptionRectangle, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CaptionRectangle requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("height");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Height))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Height));
                }
                else
                {
                    context.Writer.Write(requestObject.Height);
                }
            }

            if(requestObject.IsSetLeftOffset())
            {
                context.Writer.WritePropertyName("leftOffset");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LeftOffset))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.LeftOffset));
                }
                else
                {
                    context.Writer.Write(requestObject.LeftOffset);
                }
            }

            if(requestObject.IsSetTopOffset())
            {
                context.Writer.WritePropertyName("topOffset");
                if(StringUtils.IsSpecialDoubleValue(requestObject.TopOffset))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.TopOffset));
                }
                else
                {
                    context.Writer.Write(requestObject.TopOffset);
                }
            }

            if(requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("width");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Width))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Width));
                }
                else
                {
                    context.Writer.Write(requestObject.Width);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CaptionRectangleMarshaller Instance = new CaptionRectangleMarshaller();

    }
}