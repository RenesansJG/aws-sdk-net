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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsCertificateManagerCertificateDomainValidationOption Object
    /// </summary>  
    public class AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller : IUnmarshaller<AwsCertificateManagerCertificateDomainValidationOption, XmlUnmarshallerContext>, IUnmarshaller<AwsCertificateManagerCertificateDomainValidationOption, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsCertificateManagerCertificateDomainValidationOption IUnmarshaller<AwsCertificateManagerCertificateDomainValidationOption, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsCertificateManagerCertificateDomainValidationOption Unmarshall(JsonUnmarshallerContext context)
        {
            AwsCertificateManagerCertificateDomainValidationOption unmarshalledObject = new AwsCertificateManagerCertificateDomainValidationOption();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceRecord", targetDepth))
                {
                    var unmarshaller = AwsCertificateManagerCertificateResourceRecordUnmarshaller.Instance;
                    unmarshalledObject.ResourceRecord = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ValidationDomain", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ValidationDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ValidationEmails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ValidationEmails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ValidationMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ValidationMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ValidationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ValidationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller _instance = new AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsCertificateManagerCertificateDomainValidationOptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}