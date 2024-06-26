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
    /// AacSettings Marshaller
    /// </summary>
    public class AacSettingsMarshaller : IRequestMarshaller<AacSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AacSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Bitrate))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Bitrate));
                }
                else
                {
                    context.Writer.Write(requestObject.Bitrate);
                }
            }

            if(requestObject.IsSetCodingMode())
            {
                context.Writer.WritePropertyName("codingMode");
                context.Writer.Write(requestObject.CodingMode);
            }

            if(requestObject.IsSetInputType())
            {
                context.Writer.WritePropertyName("inputType");
                context.Writer.Write(requestObject.InputType);
            }

            if(requestObject.IsSetProfile())
            {
                context.Writer.WritePropertyName("profile");
                context.Writer.Write(requestObject.Profile);
            }

            if(requestObject.IsSetRateControlMode())
            {
                context.Writer.WritePropertyName("rateControlMode");
                context.Writer.Write(requestObject.RateControlMode);
            }

            if(requestObject.IsSetRawFormat())
            {
                context.Writer.WritePropertyName("rawFormat");
                context.Writer.Write(requestObject.RawFormat);
            }

            if(requestObject.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("sampleRate");
                if(StringUtils.IsSpecialDoubleValue(requestObject.SampleRate))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.SampleRate));
                }
                else
                {
                    context.Writer.Write(requestObject.SampleRate);
                }
            }

            if(requestObject.IsSetSpec())
            {
                context.Writer.WritePropertyName("spec");
                context.Writer.Write(requestObject.Spec);
            }

            if(requestObject.IsSetVbrQuality())
            {
                context.Writer.WritePropertyName("vbrQuality");
                context.Writer.Write(requestObject.VbrQuality);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AacSettingsMarshaller Instance = new AacSettingsMarshaller();

    }
}