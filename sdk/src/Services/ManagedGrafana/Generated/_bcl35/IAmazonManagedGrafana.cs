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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ManagedGrafana.Model;

#pragma warning disable CS1570
namespace Amazon.ManagedGrafana
{
    /// <summary>
    /// <para>Interface for accessing ManagedGrafana</para>
    ///
    /// Amazon Managed Grafana is a fully managed and secure data visualization service that
    /// you can use to instantly query, correlate, and visualize operational metrics, logs,
    /// and traces from multiple sources. Amazon Managed Grafana makes it easy to deploy,
    /// operate, and scale Grafana, a widely deployed data visualization tool that is popular
    /// for its extensible data support.
    /// 
    ///  
    /// <para>
    /// With Amazon Managed Grafana, you create logically isolated Grafana servers called
    /// <i>workspaces</i>. In a workspace, you can create Grafana dashboards and visualizations
    /// to analyze your metrics, logs, and traces without having to build, package, or deploy
    /// any hardware to run Grafana servers. 
    /// </para>
    /// </summary>
    public partial interface IAmazonManagedGrafana : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IManagedGrafanaPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateLicense


        /// <summary>
        /// Assigns a Grafana Enterprise license to a workspace. To upgrade, you must use <c>ENTERPRISE</c>
        /// for the <c>licenseType</c>, and pass in a valid Grafana Labs token for the <c>grafanaToken</c>.
        /// Upgrading to Grafana Enterprise incurs additional fees. For more information, see
        /// <a href="https://docs.aws.amazon.com/grafana/latest/userguide/upgrade-to-Grafana-Enterprise.html">Upgrade
        /// a workspace to Grafana Enterprise</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLicense service method.</param>
        /// 
        /// <returns>The response from the AssociateLicense service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/AssociateLicense">REST API Reference for AssociateLicense Operation</seealso>
        AssociateLicenseResponse AssociateLicense(AssociateLicenseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateLicense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateLicense operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateLicense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/AssociateLicense">REST API Reference for AssociateLicense Operation</seealso>
        IAsyncResult BeginAssociateLicense(AssociateLicenseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateLicense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateLicense.</param>
        /// 
        /// <returns>Returns a  AssociateLicenseResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/AssociateLicense">REST API Reference for AssociateLicense Operation</seealso>
        AssociateLicenseResponse EndAssociateLicense(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkspace


        /// <summary>
        /// Creates a <i>workspace</i>. In a workspace, you can create Grafana dashboards and
        /// visualizations to analyze your metrics, logs, and traces. You don't have to build,
        /// package, or deploy any hardware to run the Grafana server.
        /// 
        ///  
        /// <para>
        /// Don't use <c>CreateWorkspace</c> to modify an existing workspace. Instead, use <a
        /// href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspace.html">UpdateWorkspace</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        IAsyncResult BeginCreateWorkspace(CreateWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspace.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        CreateWorkspaceResponse EndCreateWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkspaceApiKey


        /// <summary>
        /// Creates a Grafana API key for the workspace. This key can be used to authenticate
        /// requests sent to the workspace's HTTP API. See <a href="https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html">https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html</a>
        /// for available APIs and example requests.
        /// 
        ///  <note> 
        /// <para>
        /// In workspaces compatible with Grafana version 9 or above, use workspace service accounts
        /// instead of API keys. API keys will be removed in a future release.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceApiKey service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaceApiKey service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceApiKey">REST API Reference for CreateWorkspaceApiKey Operation</seealso>
        CreateWorkspaceApiKeyResponse CreateWorkspaceApiKey(CreateWorkspaceApiKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspaceApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceApiKey operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspaceApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceApiKey">REST API Reference for CreateWorkspaceApiKey Operation</seealso>
        IAsyncResult BeginCreateWorkspaceApiKey(CreateWorkspaceApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaceApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaceApiKey.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceApiKeyResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceApiKey">REST API Reference for CreateWorkspaceApiKey Operation</seealso>
        CreateWorkspaceApiKeyResponse EndCreateWorkspaceApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkspaceServiceAccount


        /// <summary>
        /// Creates a service account for the workspace. A service account can be used to call
        /// Grafana HTTP APIs, and run automated workloads. After creating the service account
        /// with the correct <c>GrafanaRole</c> for your use case, use <c>CreateWorkspaceServiceAccountToken</c>
        /// to create a token that can be used to authenticate and authorize Grafana HTTP API
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can only create service accounts for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        ///  <note> 
        /// <para>
        /// For more information about service accounts, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/service-accounts.html">Service
        /// accounts</a> in the <i>Amazon Managed Grafana User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the Grafana HTTP APIs, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html">Using
        /// Grafana HTTP APIs</a> in the <i>Amazon Managed Grafana User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceServiceAccount service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaceServiceAccount service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceServiceAccount">REST API Reference for CreateWorkspaceServiceAccount Operation</seealso>
        CreateWorkspaceServiceAccountResponse CreateWorkspaceServiceAccount(CreateWorkspaceServiceAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspaceServiceAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceServiceAccount operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspaceServiceAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceServiceAccount">REST API Reference for CreateWorkspaceServiceAccount Operation</seealso>
        IAsyncResult BeginCreateWorkspaceServiceAccount(CreateWorkspaceServiceAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaceServiceAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaceServiceAccount.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceServiceAccountResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceServiceAccount">REST API Reference for CreateWorkspaceServiceAccount Operation</seealso>
        CreateWorkspaceServiceAccountResponse EndCreateWorkspaceServiceAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkspaceServiceAccountToken


        /// <summary>
        /// Creates a token that can be used to authenticate and authorize Grafana HTTP API operations
        /// for the given <a href="https://docs.aws.amazon.com/grafana/latest/userguide/service-accounts.html">workspace
        /// service account</a>. The service account acts as a user for the API operations, and
        /// defines the permissions that are used by the API.
        /// 
        ///  <important> 
        /// <para>
        /// When you create the service account token, you will receive a key that is used when
        /// calling Grafana APIs. Do not lose this key, as it will not be retrievable again.
        /// </para>
        ///  
        /// <para>
        /// If you do lose the key, you can delete the token and recreate it to receive a new
        /// key. This will disable the initial key.
        /// </para>
        ///  </important> 
        /// <para>
        /// Service accounts are only available for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceServiceAccountToken service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaceServiceAccountToken service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceServiceAccountToken">REST API Reference for CreateWorkspaceServiceAccountToken Operation</seealso>
        CreateWorkspaceServiceAccountTokenResponse CreateWorkspaceServiceAccountToken(CreateWorkspaceServiceAccountTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspaceServiceAccountToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceServiceAccountToken operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspaceServiceAccountToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceServiceAccountToken">REST API Reference for CreateWorkspaceServiceAccountToken Operation</seealso>
        IAsyncResult BeginCreateWorkspaceServiceAccountToken(CreateWorkspaceServiceAccountTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaceServiceAccountToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaceServiceAccountToken.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceServiceAccountTokenResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceServiceAccountToken">REST API Reference for CreateWorkspaceServiceAccountToken Operation</seealso>
        CreateWorkspaceServiceAccountTokenResponse EndCreateWorkspaceServiceAccountToken(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkspace


        /// <summary>
        /// Deletes an Amazon Managed Grafana workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        IAsyncResult BeginDeleteWorkspace(DeleteWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspace.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        DeleteWorkspaceResponse EndDeleteWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkspaceApiKey


        /// <summary>
        /// Deletes a Grafana API key for the workspace.
        /// 
        ///  <note> 
        /// <para>
        /// In workspaces compatible with Grafana version 9 or above, use workspace service accounts
        /// instead of API keys. API keys will be removed in a future release.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceApiKey service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspaceApiKey service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceApiKey">REST API Reference for DeleteWorkspaceApiKey Operation</seealso>
        DeleteWorkspaceApiKeyResponse DeleteWorkspaceApiKey(DeleteWorkspaceApiKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspaceApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceApiKey operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspaceApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceApiKey">REST API Reference for DeleteWorkspaceApiKey Operation</seealso>
        IAsyncResult BeginDeleteWorkspaceApiKey(DeleteWorkspaceApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspaceApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspaceApiKey.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceApiKeyResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceApiKey">REST API Reference for DeleteWorkspaceApiKey Operation</seealso>
        DeleteWorkspaceApiKeyResponse EndDeleteWorkspaceApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkspaceServiceAccount


        /// <summary>
        /// Deletes a workspace service account from the workspace.
        /// 
        ///  
        /// <para>
        /// This will delete any tokens created for the service account, as well. If the tokens
        /// are currently in use, the will fail to authenticate / authorize after they are deleted.
        /// </para>
        ///  
        /// <para>
        /// Service accounts are only available for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceServiceAccount service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspaceServiceAccount service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceServiceAccount">REST API Reference for DeleteWorkspaceServiceAccount Operation</seealso>
        DeleteWorkspaceServiceAccountResponse DeleteWorkspaceServiceAccount(DeleteWorkspaceServiceAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspaceServiceAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceServiceAccount operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspaceServiceAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceServiceAccount">REST API Reference for DeleteWorkspaceServiceAccount Operation</seealso>
        IAsyncResult BeginDeleteWorkspaceServiceAccount(DeleteWorkspaceServiceAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspaceServiceAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspaceServiceAccount.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceServiceAccountResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceServiceAccount">REST API Reference for DeleteWorkspaceServiceAccount Operation</seealso>
        DeleteWorkspaceServiceAccountResponse EndDeleteWorkspaceServiceAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkspaceServiceAccountToken


        /// <summary>
        /// Deletes a token for the workspace service account.
        /// 
        ///  
        /// <para>
        /// This will disable the key associated with the token. If any automation is currently
        /// using the key, it will no longer be authenticated or authorized to perform actions
        /// with the Grafana HTTP APIs.
        /// </para>
        ///  
        /// <para>
        /// Service accounts are only available for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceServiceAccountToken service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspaceServiceAccountToken service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceServiceAccountToken">REST API Reference for DeleteWorkspaceServiceAccountToken Operation</seealso>
        DeleteWorkspaceServiceAccountTokenResponse DeleteWorkspaceServiceAccountToken(DeleteWorkspaceServiceAccountTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspaceServiceAccountToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceServiceAccountToken operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspaceServiceAccountToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceServiceAccountToken">REST API Reference for DeleteWorkspaceServiceAccountToken Operation</seealso>
        IAsyncResult BeginDeleteWorkspaceServiceAccountToken(DeleteWorkspaceServiceAccountTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspaceServiceAccountToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspaceServiceAccountToken.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceServiceAccountTokenResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceServiceAccountToken">REST API Reference for DeleteWorkspaceServiceAccountToken Operation</seealso>
        DeleteWorkspaceServiceAccountTokenResponse EndDeleteWorkspaceServiceAccountToken(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkspace


        /// <summary>
        /// Displays information about one Amazon Managed Grafana workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        DescribeWorkspaceResponse DescribeWorkspace(DescribeWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        IAsyncResult BeginDescribeWorkspace(DescribeWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspace.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        DescribeWorkspaceResponse EndDescribeWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkspaceAuthentication


        /// <summary>
        /// Displays information about the authentication methods used in one Amazon Managed Grafana
        /// workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceAuthentication service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceAuthentication service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceAuthentication">REST API Reference for DescribeWorkspaceAuthentication Operation</seealso>
        DescribeWorkspaceAuthenticationResponse DescribeWorkspaceAuthentication(DescribeWorkspaceAuthenticationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceAuthentication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceAuthentication operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceAuthentication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceAuthentication">REST API Reference for DescribeWorkspaceAuthentication Operation</seealso>
        IAsyncResult BeginDescribeWorkspaceAuthentication(DescribeWorkspaceAuthenticationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceAuthentication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceAuthentication.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceAuthenticationResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceAuthentication">REST API Reference for DescribeWorkspaceAuthentication Operation</seealso>
        DescribeWorkspaceAuthenticationResponse EndDescribeWorkspaceAuthentication(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkspaceConfiguration


        /// <summary>
        /// Gets the current configuration string for the given workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceConfiguration service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        DescribeWorkspaceConfigurationResponse DescribeWorkspaceConfiguration(DescribeWorkspaceConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceConfiguration operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        IAsyncResult BeginDescribeWorkspaceConfiguration(DescribeWorkspaceConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceConfigurationResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        DescribeWorkspaceConfigurationResponse EndDescribeWorkspaceConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateLicense


        /// <summary>
        /// Removes the Grafana Enterprise license from a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLicense service method.</param>
        /// 
        /// <returns>The response from the DisassociateLicense service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DisassociateLicense">REST API Reference for DisassociateLicense Operation</seealso>
        DisassociateLicenseResponse DisassociateLicense(DisassociateLicenseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateLicense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLicense operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateLicense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DisassociateLicense">REST API Reference for DisassociateLicense Operation</seealso>
        IAsyncResult BeginDisassociateLicense(DisassociateLicenseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateLicense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateLicense.</param>
        /// 
        /// <returns>Returns a  DisassociateLicenseResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DisassociateLicense">REST API Reference for DisassociateLicense Operation</seealso>
        DisassociateLicenseResponse EndDisassociateLicense(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPermissions


        /// <summary>
        /// Lists the users and groups who have the Grafana <c>Admin</c> and <c>Editor</c> roles
        /// in this workspace. If you use this operation without specifying <c>userId</c> or <c>groupId</c>,
        /// the operation returns the roles of all users and groups. If you specify a <c>userId</c>
        /// or a <c>groupId</c>, only the roles for that user or group are returned. If you do
        /// this, you can specify only one <c>userId</c> or one <c>groupId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        ListPermissionsResponse ListPermissions(ListPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        IAsyncResult BeginListPermissions(ListPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissions.</param>
        /// 
        /// <returns>Returns a  ListPermissionsResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        ListPermissionsResponse EndListPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// The <c>ListTagsForResource</c> operation returns the tags that are associated with
        /// the Amazon Managed Service for Grafana resource specified by the <c>resourceArn</c>.
        /// Currently, the only resource that can be tagged is a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVersions


        /// <summary>
        /// Lists available versions of Grafana. These are available when calling <c>CreateWorkspace</c>.
        /// Optionally, include a workspace to list the versions to which it can be upgraded.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListVersions">REST API Reference for ListVersions Operation</seealso>
        ListVersionsResponse ListVersions(ListVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListVersions">REST API Reference for ListVersions Operation</seealso>
        IAsyncResult BeginListVersions(ListVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// 
        /// <returns>Returns a  ListVersionsResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListVersions">REST API Reference for ListVersions Operation</seealso>
        ListVersionsResponse EndListVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkspaces


        /// <summary>
        /// Returns a list of Amazon Managed Grafana workspaces in the account, with some information
        /// about each workspace. For more complete information about one workspace, use <a href="https://docs.aws.amazon.com/AAMG/latest/APIReference/API_DescribeWorkspace.html">DescribeWorkspace</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        IAsyncResult BeginListWorkspaces(ListWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkspaces.</param>
        /// 
        /// <returns>Returns a  ListWorkspacesResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        ListWorkspacesResponse EndListWorkspaces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkspaceServiceAccounts


        /// <summary>
        /// Returns a list of service accounts for a workspace.
        /// 
        ///  
        /// <para>
        /// Service accounts are only available for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceServiceAccounts service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaceServiceAccounts service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaceServiceAccounts">REST API Reference for ListWorkspaceServiceAccounts Operation</seealso>
        ListWorkspaceServiceAccountsResponse ListWorkspaceServiceAccounts(ListWorkspaceServiceAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkspaceServiceAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceServiceAccounts operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkspaceServiceAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaceServiceAccounts">REST API Reference for ListWorkspaceServiceAccounts Operation</seealso>
        IAsyncResult BeginListWorkspaceServiceAccounts(ListWorkspaceServiceAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkspaceServiceAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkspaceServiceAccounts.</param>
        /// 
        /// <returns>Returns a  ListWorkspaceServiceAccountsResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaceServiceAccounts">REST API Reference for ListWorkspaceServiceAccounts Operation</seealso>
        ListWorkspaceServiceAccountsResponse EndListWorkspaceServiceAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkspaceServiceAccountTokens


        /// <summary>
        /// Returns a list of tokens for a workspace service account.
        /// 
        ///  <note> 
        /// <para>
        /// This does not return the key for each token. You cannot access keys after they are
        /// created. To create a new key, delete the token and recreate it.
        /// </para>
        ///  </note> 
        /// <para>
        /// Service accounts are only available for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceServiceAccountTokens service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaceServiceAccountTokens service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaceServiceAccountTokens">REST API Reference for ListWorkspaceServiceAccountTokens Operation</seealso>
        ListWorkspaceServiceAccountTokensResponse ListWorkspaceServiceAccountTokens(ListWorkspaceServiceAccountTokensRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkspaceServiceAccountTokens operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceServiceAccountTokens operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkspaceServiceAccountTokens
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaceServiceAccountTokens">REST API Reference for ListWorkspaceServiceAccountTokens Operation</seealso>
        IAsyncResult BeginListWorkspaceServiceAccountTokens(ListWorkspaceServiceAccountTokensRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkspaceServiceAccountTokens operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkspaceServiceAccountTokens.</param>
        /// 
        /// <returns>Returns a  ListWorkspaceServiceAccountTokensResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaceServiceAccountTokens">REST API Reference for ListWorkspaceServiceAccountTokens Operation</seealso>
        ListWorkspaceServiceAccountTokensResponse EndListWorkspaceServiceAccountTokens(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// The <c>TagResource</c> operation associates tags with an Amazon Managed Grafana resource.
        /// Currently, the only resource that can be tagged is workspaces. 
        /// 
        ///  
        /// <para>
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the resource. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// The <c>UntagResource</c> operation removes the association of the tag with the Amazon
        /// Managed Grafana resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePermissions


        /// <summary>
        /// Updates which users in a workspace have the Grafana <c>Admin</c> or <c>Editor</c>
        /// roles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdatePermissions service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdatePermissions">REST API Reference for UpdatePermissions Operation</seealso>
        UpdatePermissionsResponse UpdatePermissions(UpdatePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissions operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdatePermissions">REST API Reference for UpdatePermissions Operation</seealso>
        IAsyncResult BeginUpdatePermissions(UpdatePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePermissions.</param>
        /// 
        /// <returns>Returns a  UpdatePermissionsResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdatePermissions">REST API Reference for UpdatePermissions Operation</seealso>
        UpdatePermissionsResponse EndUpdatePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkspace


        /// <summary>
        /// Modifies an existing Amazon Managed Grafana workspace. If you use this operation and
        /// omit any optional parameters, the existing values of those parameters are not changed.
        /// 
        ///  
        /// <para>
        /// To modify the user authentication methods that the workspace uses, such as SAML or
        /// IAM Identity Center, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspaceAuthentication.html">UpdateWorkspaceAuthentication</a>.
        /// </para>
        ///  
        /// <para>
        /// To modify which users in the workspace have the <c>Admin</c> and <c>Editor</c> Grafana
        /// roles, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdatePermissions.html">UpdatePermissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        UpdateWorkspaceResponse UpdateWorkspace(UpdateWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        IAsyncResult BeginUpdateWorkspace(UpdateWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspace.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        UpdateWorkspaceResponse EndUpdateWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkspaceAuthentication


        /// <summary>
        /// Use this operation to define the identity provider (IdP) that this workspace authenticates
        /// users from, using SAML. You can also map SAML assertion attributes to workspace user
        /// information and define which groups in the assertion attribute are to have the <c>Admin</c>
        /// and <c>Editor</c> roles in the workspace.
        /// 
        ///  <note> 
        /// <para>
        /// Changes to the authentication method for a workspace may take a few minutes to take
        /// effect.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAuthentication service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspaceAuthentication service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceAuthentication">REST API Reference for UpdateWorkspaceAuthentication Operation</seealso>
        UpdateWorkspaceAuthenticationResponse UpdateWorkspaceAuthentication(UpdateWorkspaceAuthenticationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspaceAuthentication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAuthentication operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspaceAuthentication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceAuthentication">REST API Reference for UpdateWorkspaceAuthentication Operation</seealso>
        IAsyncResult BeginUpdateWorkspaceAuthentication(UpdateWorkspaceAuthenticationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceAuthentication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceAuthentication.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceAuthenticationResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceAuthentication">REST API Reference for UpdateWorkspaceAuthentication Operation</seealso>
        UpdateWorkspaceAuthenticationResponse EndUpdateWorkspaceAuthentication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkspaceConfiguration


        /// <summary>
        /// Updates the configuration string for the given workspace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspaceConfiguration service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        UpdateWorkspaceConfigurationResponse UpdateWorkspaceConfiguration(UpdateWorkspaceConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceConfiguration operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspaceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        IAsyncResult BeginUpdateWorkspaceConfiguration(UpdateWorkspaceConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceConfigurationResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        UpdateWorkspaceConfigurationResponse EndUpdateWorkspaceConfiguration(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}