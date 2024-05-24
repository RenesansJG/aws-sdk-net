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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ARCZonalShift.Model;
using Amazon.ARCZonalShift.Model.Internal.MarshallTransformations;
using Amazon.ARCZonalShift.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ARCZonalShift
{
    /// <summary>
    /// <para>Implementation for accessing ARCZonalShift</para>
    ///
    /// Welcome to the Zonal Shift API Reference Guide for Amazon Route 53 Application Recovery
    /// Controller (Route 53 ARC).
    /// 
    ///  
    /// <para>
    /// You can start a zonal shift to move traffic for a load balancer resource away from
    /// an Availability Zone to help your application recover quickly from an impairment in
    /// an Availability Zone. For example, you can recover your application from a developer's
    /// bad code deployment or from an Amazon Web Services infrastructure failure in a single
    /// Availability Zone.
    /// </para>
    ///  
    /// <para>
    /// You can also configure zonal autoshift for a load balancer resource. Zonal autoshift
    /// is a capability in Route 53 ARC where Amazon Web Services shifts away application
    /// resource traffic from an Availability Zone, on your behalf, to help reduce your time
    /// to recovery during events. Amazon Web Services shifts away traffic for resources that
    /// are enabled for zonal autoshift whenever Amazon Web Services determines that there's
    /// an issue in the Availability Zone that could potentially affect customers.
    /// </para>
    ///  
    /// <para>
    /// To ensure that zonal autoshift is safe for your application, you must also configure
    /// practice runs when you enable zonal autoshift for a resource. Practice runs start
    /// weekly zonal shifts for a resource, to shift traffic for the resource out of an Availability
    /// Zone. Practice runs make sure, on a regular basis, that you have enough capacity in
    /// all the Availability Zones in an Amazon Web Services Region for your application to
    /// continue to operate normally when traffic for a resource is shifted away from one
    /// Availability Zone.
    /// </para>
    ///  <important> 
    /// <para>
    /// You must prescale resource capacity in all Availability Zones in the Region where
    /// your application is deployed, before you configure practice runs or enable zonal autoshift
    /// for a resource. You should not rely on scaling on demand when an autoshift or practice
    /// run starts. 
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about using zonal shift and zonal autoshift, see the <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/what-is-route53-recovery.html">Amazon
    /// Route 53 Application Recovery Controller Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonARCZonalShiftClient : AmazonServiceClient, IAmazonARCZonalShift
    {
        private static IServiceMetadata serviceMetadata = new AmazonARCZonalShiftMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IARCZonalShiftPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IARCZonalShiftPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ARCZonalShiftPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonARCZonalShiftClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonARCZonalShiftConfig()) { }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonARCZonalShiftClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonARCZonalShiftConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonARCZonalShiftClient Configuration Object</param>
        public AmazonARCZonalShiftClient(AmazonARCZonalShiftConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonARCZonalShiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonARCZonalShiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCZonalShiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonARCZonalShiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Credentials and an
        /// AmazonARCZonalShiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonARCZonalShiftClient Configuration Object</param>
        public AmazonARCZonalShiftClient(AWSCredentials credentials, AmazonARCZonalShiftConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonARCZonalShiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonARCZonalShiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonARCZonalShiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonARCZonalShiftClient Configuration Object</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonARCZonalShiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonARCZonalShiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonARCZonalShiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCZonalShiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonARCZonalShiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonARCZonalShiftClient Configuration Object</param>
        public AmazonARCZonalShiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonARCZonalShiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonARCZonalShiftEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CancelZonalShift

        /// <summary>
        /// Cancel a zonal shift in Amazon Route 53 Application Recovery Controller. To cancel
        /// the zonal shift, specify the zonal shift ID.
        /// 
        ///  
        /// <para>
        /// A zonal shift can be one that you've started for a resource in your Amazon Web Services
        /// account in an Amazon Web Services Region, or it can be a zonal shift started by a
        /// practice run with zonal autoshift. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelZonalShift service method.</param>
        /// 
        /// <returns>The response from the CancelZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelZonalShift">REST API Reference for CancelZonalShift Operation</seealso>
        public virtual CancelZonalShiftResponse CancelZonalShift(CancelZonalShiftRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelZonalShiftResponseUnmarshaller.Instance;

            return Invoke<CancelZonalShiftResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelZonalShift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelZonalShift operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelZonalShift
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelZonalShift">REST API Reference for CancelZonalShift Operation</seealso>
        public virtual IAsyncResult BeginCancelZonalShift(CancelZonalShiftRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelZonalShiftResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelZonalShift operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelZonalShift.</param>
        /// 
        /// <returns>Returns a  CancelZonalShiftResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelZonalShift">REST API Reference for CancelZonalShift Operation</seealso>
        public virtual CancelZonalShiftResponse EndCancelZonalShift(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelZonalShiftResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePracticeRunConfiguration

        /// <summary>
        /// A practice run configuration for zonal autoshift is required when you enable zonal
        /// autoshift. A practice run configuration includes specifications for blocked dates
        /// and blocked time windows, and for Amazon CloudWatch alarms that you create to use
        /// with practice runs. The alarms that you specify are an <i>outcome alarm</i>, to monitor
        /// application health during practice runs and, optionally, a <i>blocking alarm</i>,
        /// to block practice runs from starting.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.considerations.html">
        /// Considerations when you configure zonal autoshift</a> in the Amazon Route 53 Application
        /// Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePracticeRunConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreatePracticeRunConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CreatePracticeRunConfiguration">REST API Reference for CreatePracticeRunConfiguration Operation</seealso>
        public virtual CreatePracticeRunConfigurationResponse CreatePracticeRunConfiguration(CreatePracticeRunConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePracticeRunConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreatePracticeRunConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePracticeRunConfiguration operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePracticeRunConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CreatePracticeRunConfiguration">REST API Reference for CreatePracticeRunConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreatePracticeRunConfiguration(CreatePracticeRunConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePracticeRunConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePracticeRunConfiguration.</param>
        /// 
        /// <returns>Returns a  CreatePracticeRunConfigurationResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CreatePracticeRunConfiguration">REST API Reference for CreatePracticeRunConfiguration Operation</seealso>
        public virtual CreatePracticeRunConfigurationResponse EndCreatePracticeRunConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePracticeRunConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePracticeRunConfiguration

        /// <summary>
        /// Deletes the practice run configuration for a resource. Before you can delete a practice
        /// run configuration for a resource., you must disable zonal autoshift for the resource.
        /// Practice runs must be configured for zonal autoshift to be enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePracticeRunConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeletePracticeRunConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/DeletePracticeRunConfiguration">REST API Reference for DeletePracticeRunConfiguration Operation</seealso>
        public virtual DeletePracticeRunConfigurationResponse DeletePracticeRunConfiguration(DeletePracticeRunConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePracticeRunConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeletePracticeRunConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePracticeRunConfiguration operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePracticeRunConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/DeletePracticeRunConfiguration">REST API Reference for DeletePracticeRunConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeletePracticeRunConfiguration(DeletePracticeRunConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePracticeRunConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePracticeRunConfiguration.</param>
        /// 
        /// <returns>Returns a  DeletePracticeRunConfigurationResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/DeletePracticeRunConfiguration">REST API Reference for DeletePracticeRunConfiguration Operation</seealso>
        public virtual DeletePracticeRunConfigurationResponse EndDeletePracticeRunConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePracticeRunConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetManagedResource

        /// <summary>
        /// Get information about a resource that's been registered for zonal shifts with Amazon
        /// Route 53 Application Recovery Controller in this Amazon Web Services Region. Resources
        /// that are registered for zonal shifts are managed resources in Route 53 ARC. You can
        /// start zonal shifts and configure zonal autoshift for managed resources.
        /// 
        ///  
        /// <para>
        /// At this time, you can only start a zonal shift or configure zonal autoshift for Network
        /// Load Balancers and Application Load Balancers with cross-zone load balancing turned
        /// off.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedResource service method.</param>
        /// 
        /// <returns>The response from the GetManagedResource service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetManagedResource">REST API Reference for GetManagedResource Operation</seealso>
        public virtual GetManagedResourceResponse GetManagedResource(GetManagedResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedResourceResponseUnmarshaller.Instance;

            return Invoke<GetManagedResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedResource operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetManagedResource">REST API Reference for GetManagedResource Operation</seealso>
        public virtual IAsyncResult BeginGetManagedResource(GetManagedResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedResource.</param>
        /// 
        /// <returns>Returns a  GetManagedResourceResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetManagedResource">REST API Reference for GetManagedResource Operation</seealso>
        public virtual GetManagedResourceResponse EndGetManagedResource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAutoshifts

        /// <summary>
        /// Returns the active autoshifts for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoshifts service method.</param>
        /// 
        /// <returns>The response from the ListAutoshifts service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListAutoshifts">REST API Reference for ListAutoshifts Operation</seealso>
        public virtual ListAutoshiftsResponse ListAutoshifts(ListAutoshiftsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAutoshiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutoshiftsResponseUnmarshaller.Instance;

            return Invoke<ListAutoshiftsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutoshifts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutoshifts operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutoshifts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListAutoshifts">REST API Reference for ListAutoshifts Operation</seealso>
        public virtual IAsyncResult BeginListAutoshifts(ListAutoshiftsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAutoshiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutoshiftsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutoshifts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutoshifts.</param>
        /// 
        /// <returns>Returns a  ListAutoshiftsResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListAutoshifts">REST API Reference for ListAutoshifts Operation</seealso>
        public virtual ListAutoshiftsResponse EndListAutoshifts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAutoshiftsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListManagedResources

        /// <summary>
        /// Lists all the resources in your Amazon Web Services account in this Amazon Web Services
        /// Region that are managed for zonal shifts in Amazon Route 53 Application Recovery Controller,
        /// and information about them. The information includes the zonal autoshift status for
        /// the resource, as well as the Amazon Resource Name (ARN), the Availability Zones that
        /// each resource is deployed in, and the resource name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedResources service method.</param>
        /// 
        /// <returns>The response from the ListManagedResources service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListManagedResources">REST API Reference for ListManagedResources Operation</seealso>
        public virtual ListManagedResourcesResponse ListManagedResources(ListManagedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListManagedResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedResources operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListManagedResources">REST API Reference for ListManagedResources Operation</seealso>
        public virtual IAsyncResult BeginListManagedResources(ListManagedResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedResources.</param>
        /// 
        /// <returns>Returns a  ListManagedResourcesResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListManagedResources">REST API Reference for ListManagedResources Operation</seealso>
        public virtual ListManagedResourcesResponse EndListManagedResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListZonalShifts

        /// <summary>
        /// Lists all active and completed zonal shifts in Amazon Route 53 Application Recovery
        /// Controller in your Amazon Web Services account in this Amazon Web Services Region.
        /// <c>ListZonalShifts</c> returns customer-started zonal shifts, as well as practice
        /// run zonal shifts that Route 53 ARC started on your behalf for zonal autoshift.
        /// 
        ///  
        /// <para>
        /// The <c>ListZonalShifts</c> operation does not list autoshifts. For more information
        /// about listing autoshifts, see <a href="https://docs.aws.amazon.com/arc-zonal-shift/latest/api/API_ListAutoshifts.html">"&gt;ListAutoshifts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListZonalShifts service method.</param>
        /// 
        /// <returns>The response from the ListZonalShifts service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListZonalShifts">REST API Reference for ListZonalShifts Operation</seealso>
        public virtual ListZonalShiftsResponse ListZonalShifts(ListZonalShiftsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListZonalShiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListZonalShiftsResponseUnmarshaller.Instance;

            return Invoke<ListZonalShiftsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListZonalShifts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListZonalShifts operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListZonalShifts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListZonalShifts">REST API Reference for ListZonalShifts Operation</seealso>
        public virtual IAsyncResult BeginListZonalShifts(ListZonalShiftsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListZonalShiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListZonalShiftsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListZonalShifts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListZonalShifts.</param>
        /// 
        /// <returns>Returns a  ListZonalShiftsResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListZonalShifts">REST API Reference for ListZonalShifts Operation</seealso>
        public virtual ListZonalShiftsResponse EndListZonalShifts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListZonalShiftsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartZonalShift

        /// <summary>
        /// You start a zonal shift to temporarily move load balancer traffic away from an Availability
        /// Zone in an Amazon Web Services Region, to help your application recover immediately,
        /// for example, from a developer's bad code deployment or from an Amazon Web Services
        /// infrastructure failure in a single Availability Zone. You can start a zonal shift
        /// in Route 53 ARC only for managed resources in your Amazon Web Services account in
        /// an Amazon Web Services Region. Resources are automatically registered with Route 53
        /// ARC by Amazon Web Services services.
        /// 
        ///  
        /// <para>
        /// At this time, you can only start a zonal shift for Network Load Balancers and Application
        /// Load Balancers with cross-zone load balancing turned off.
        /// </para>
        ///  
        /// <para>
        /// When you start a zonal shift, traffic for the resource is no longer routed to the
        /// Availability Zone. The zonal shift is created immediately in Route 53 ARC. However,
        /// it can take a short time, typically up to a few minutes, for existing, in-progress
        /// connections in the Availability Zone to complete.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.html">Zonal
        /// shift</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartZonalShift service method.</param>
        /// 
        /// <returns>The response from the StartZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartZonalShift">REST API Reference for StartZonalShift Operation</seealso>
        public virtual StartZonalShiftResponse StartZonalShift(StartZonalShiftRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartZonalShiftResponseUnmarshaller.Instance;

            return Invoke<StartZonalShiftResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartZonalShift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartZonalShift operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartZonalShift
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartZonalShift">REST API Reference for StartZonalShift Operation</seealso>
        public virtual IAsyncResult BeginStartZonalShift(StartZonalShiftRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartZonalShiftResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartZonalShift operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartZonalShift.</param>
        /// 
        /// <returns>Returns a  StartZonalShiftResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartZonalShift">REST API Reference for StartZonalShift Operation</seealso>
        public virtual StartZonalShiftResponse EndStartZonalShift(IAsyncResult asyncResult)
        {
            return EndInvoke<StartZonalShiftResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePracticeRunConfiguration

        /// <summary>
        /// Update a practice run configuration to change one or more of the following: add, change,
        /// or remove the blocking alarm; change the outcome alarm; or add, change, or remove
        /// blocking dates or time windows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePracticeRunConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdatePracticeRunConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdatePracticeRunConfiguration">REST API Reference for UpdatePracticeRunConfiguration Operation</seealso>
        public virtual UpdatePracticeRunConfigurationResponse UpdatePracticeRunConfiguration(UpdatePracticeRunConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePracticeRunConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdatePracticeRunConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePracticeRunConfiguration operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePracticeRunConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdatePracticeRunConfiguration">REST API Reference for UpdatePracticeRunConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdatePracticeRunConfiguration(UpdatePracticeRunConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePracticeRunConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePracticeRunConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePracticeRunConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePracticeRunConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdatePracticeRunConfigurationResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdatePracticeRunConfiguration">REST API Reference for UpdatePracticeRunConfiguration Operation</seealso>
        public virtual UpdatePracticeRunConfigurationResponse EndUpdatePracticeRunConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePracticeRunConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateZonalAutoshiftConfiguration

        /// <summary>
        /// You can update the zonal autoshift status for a resource, to enable or disable zonal
        /// autoshift. When zonal autoshift is <c>ENABLED</c>, Amazon Web Services shifts away
        /// resource traffic from an Availability Zone, on your behalf, when Amazon Web Services
        /// determines that there's an issue in the Availability Zone that could potentially affect
        /// customers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalAutoshiftConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateZonalAutoshiftConfiguration service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalAutoshiftConfiguration">REST API Reference for UpdateZonalAutoshiftConfiguration Operation</seealso>
        public virtual UpdateZonalAutoshiftConfigurationResponse UpdateZonalAutoshiftConfiguration(UpdateZonalAutoshiftConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateZonalAutoshiftConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateZonalAutoshiftConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateZonalAutoshiftConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateZonalAutoshiftConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalAutoshiftConfiguration operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateZonalAutoshiftConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalAutoshiftConfiguration">REST API Reference for UpdateZonalAutoshiftConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateZonalAutoshiftConfiguration(UpdateZonalAutoshiftConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateZonalAutoshiftConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateZonalAutoshiftConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateZonalAutoshiftConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateZonalAutoshiftConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateZonalAutoshiftConfigurationResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalAutoshiftConfiguration">REST API Reference for UpdateZonalAutoshiftConfiguration Operation</seealso>
        public virtual UpdateZonalAutoshiftConfigurationResponse EndUpdateZonalAutoshiftConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateZonalAutoshiftConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateZonalShift

        /// <summary>
        /// Update an active zonal shift in Amazon Route 53 Application Recovery Controller in
        /// your Amazon Web Services account. You can update a zonal shift to set a new expiration,
        /// or edit or replace the comment for the zonal shift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalShift service method.</param>
        /// 
        /// <returns>The response from the UpdateZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalShift">REST API Reference for UpdateZonalShift Operation</seealso>
        public virtual UpdateZonalShiftResponse UpdateZonalShift(UpdateZonalShiftRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateZonalShiftResponseUnmarshaller.Instance;

            return Invoke<UpdateZonalShiftResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateZonalShift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalShift operation on AmazonARCZonalShiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateZonalShift
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalShift">REST API Reference for UpdateZonalShift Operation</seealso>
        public virtual IAsyncResult BeginUpdateZonalShift(UpdateZonalShiftRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateZonalShiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateZonalShiftResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateZonalShift operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateZonalShift.</param>
        /// 
        /// <returns>Returns a  UpdateZonalShiftResult from ARCZonalShift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalShift">REST API Reference for UpdateZonalShift Operation</seealso>
        public virtual UpdateZonalShiftResponse EndUpdateZonalShift(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateZonalShiftResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonARCZonalShiftEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}