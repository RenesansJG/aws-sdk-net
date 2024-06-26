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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudSearch.Model;

#pragma warning disable CS1570
namespace Amazon.CloudSearch
{
    /// <summary>
    /// <para>Interface for accessing CloudSearch</para>
    ///
    /// Amazon CloudSearch Configuration Service 
    /// <para>
    /// You use the Amazon CloudSearch configuration service to create, configure, and manage
    /// search domains. Configuration service requests are submitted using the AWS Query protocol.
    /// AWS Query requests are HTTP or HTTPS requests submitted via HTTP GET or POST with
    /// a query parameter named Action.
    /// </para>
    ///  
    /// <para>
    /// The endpoint for configuration service requests is region-specific: cloudsearch.<i>region</i>.amazonaws.com.
    /// For example, cloudsearch.us-east-1.amazonaws.com. For a current list of supported
    /// regions and endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#cloudsearch_region"
    /// target="_blank">Regions and Endpoints</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudSearch : IAmazonService, IDisposable
    {




        
        #region  BuildSuggesters


        /// <summary>
        /// Indexes the search suggestions. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html#configuring-suggesters">Configuring
        /// Suggesters</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BuildSuggesters service method.</param>
        /// 
        /// <returns>The response from the BuildSuggesters service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/BuildSuggesters">REST API Reference for BuildSuggesters Operation</seealso>
        BuildSuggestersResponse BuildSuggesters(BuildSuggestersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BuildSuggesters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BuildSuggesters operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBuildSuggesters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/BuildSuggesters">REST API Reference for BuildSuggesters Operation</seealso>
        IAsyncResult BeginBuildSuggesters(BuildSuggestersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BuildSuggesters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBuildSuggesters.</param>
        /// 
        /// <returns>Returns a  BuildSuggestersResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/BuildSuggesters">REST API Reference for BuildSuggesters Operation</seealso>
        BuildSuggestersResponse EndBuildSuggesters(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a new search domain. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/creating-domains.html"
        /// target="_blank">Creating a Search Domain</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DefineAnalysisScheme


        /// <summary>
        /// Configures an analysis scheme that can be applied to a <c>text</c> or <c>text-array</c>
        /// field to define language-specific text processing options. For more information, see
        /// <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// target="_blank">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineAnalysisScheme service method.</param>
        /// 
        /// <returns>The response from the DefineAnalysisScheme service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineAnalysisScheme">REST API Reference for DefineAnalysisScheme Operation</seealso>
        DefineAnalysisSchemeResponse DefineAnalysisScheme(DefineAnalysisSchemeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineAnalysisScheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineAnalysisScheme operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineAnalysisScheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineAnalysisScheme">REST API Reference for DefineAnalysisScheme Operation</seealso>
        IAsyncResult BeginDefineAnalysisScheme(DefineAnalysisSchemeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DefineAnalysisScheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineAnalysisScheme.</param>
        /// 
        /// <returns>Returns a  DefineAnalysisSchemeResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineAnalysisScheme">REST API Reference for DefineAnalysisScheme Operation</seealso>
        DefineAnalysisSchemeResponse EndDefineAnalysisScheme(IAsyncResult asyncResult);

        #endregion
        
        #region  DefineExpression


        /// <summary>
        /// Configures an <c><a>Expression</a></c> for the search domain. Used to create new expressions
        /// and modify existing ones. If the expression exists, the new configuration replaces
        /// the old one. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
        /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineExpression service method.</param>
        /// 
        /// <returns>The response from the DefineExpression service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineExpression">REST API Reference for DefineExpression Operation</seealso>
        DefineExpressionResponse DefineExpression(DefineExpressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineExpression operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineExpression
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineExpression">REST API Reference for DefineExpression Operation</seealso>
        IAsyncResult BeginDefineExpression(DefineExpressionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DefineExpression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineExpression.</param>
        /// 
        /// <returns>Returns a  DefineExpressionResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineExpression">REST API Reference for DefineExpression Operation</seealso>
        DefineExpressionResponse EndDefineExpression(IAsyncResult asyncResult);

        #endregion
        
        #region  DefineIndexField


        /// <summary>
        /// Configures an <c><a>IndexField</a></c> for the search domain. Used to create new fields
        /// and modify existing ones. You must specify the name of the domain you are configuring
        /// and an index field configuration. The index field configuration specifies a unique
        /// name, the index field type, and the options you want to configure for the field. The
        /// options you can specify depend on the <c><a>IndexFieldType</a></c>. If the field exists,
        /// the new configuration replaces the old one. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html"
        /// target="_blank">Configuring Index Fields</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField service method.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineIndexField">REST API Reference for DefineIndexField Operation</seealso>
        DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineIndexField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineIndexField
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineIndexField">REST API Reference for DefineIndexField Operation</seealso>
        IAsyncResult BeginDefineIndexField(DefineIndexFieldRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DefineIndexField operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineIndexField.</param>
        /// 
        /// <returns>Returns a  DefineIndexFieldResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineIndexField">REST API Reference for DefineIndexField Operation</seealso>
        DefineIndexFieldResponse EndDefineIndexField(IAsyncResult asyncResult);

        #endregion
        
        #region  DefineSuggester


        /// <summary>
        /// Configures a suggester for a domain. A suggester enables you to display possible matches
        /// before users finish typing their queries. When you configure a suggester, you must
        /// specify the name of the text field you want to search for possible matches and a unique
        /// name for the suggester. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html"
        /// target="_blank">Getting Search Suggestions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineSuggester service method.</param>
        /// 
        /// <returns>The response from the DefineSuggester service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineSuggester">REST API Reference for DefineSuggester Operation</seealso>
        DefineSuggesterResponse DefineSuggester(DefineSuggesterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineSuggester operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineSuggester operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineSuggester
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineSuggester">REST API Reference for DefineSuggester Operation</seealso>
        IAsyncResult BeginDefineSuggester(DefineSuggesterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DefineSuggester operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineSuggester.</param>
        /// 
        /// <returns>Returns a  DefineSuggesterResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DefineSuggester">REST API Reference for DefineSuggester Operation</seealso>
        DefineSuggesterResponse EndDefineSuggester(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAnalysisScheme


        /// <summary>
        /// Deletes an analysis scheme. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// target="_blank">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisScheme service method.</param>
        /// 
        /// <returns>The response from the DeleteAnalysisScheme service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteAnalysisScheme">REST API Reference for DeleteAnalysisScheme Operation</seealso>
        DeleteAnalysisSchemeResponse DeleteAnalysisScheme(DeleteAnalysisSchemeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnalysisScheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisScheme operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnalysisScheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteAnalysisScheme">REST API Reference for DeleteAnalysisScheme Operation</seealso>
        IAsyncResult BeginDeleteAnalysisScheme(DeleteAnalysisSchemeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnalysisScheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnalysisScheme.</param>
        /// 
        /// <returns>Returns a  DeleteAnalysisSchemeResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteAnalysisScheme">REST API Reference for DeleteAnalysisScheme Operation</seealso>
        DeleteAnalysisSchemeResponse EndDeleteAnalysisScheme(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Permanently deletes a search domain and all of its data. Once a domain has been deleted,
        /// it cannot be recovered. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/deleting-domains.html"
        /// target="_blank">Deleting a Search Domain</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteExpression


        /// <summary>
        /// Removes an <c><a>Expression</a></c> from the search domain. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
        /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExpression service method.</param>
        /// 
        /// <returns>The response from the DeleteExpression service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteExpression">REST API Reference for DeleteExpression Operation</seealso>
        DeleteExpressionResponse DeleteExpression(DeleteExpressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExpression operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExpression
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteExpression">REST API Reference for DeleteExpression Operation</seealso>
        IAsyncResult BeginDeleteExpression(DeleteExpressionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExpression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExpression.</param>
        /// 
        /// <returns>Returns a  DeleteExpressionResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteExpression">REST API Reference for DeleteExpression Operation</seealso>
        DeleteExpressionResponse EndDeleteExpression(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIndexField


        /// <summary>
        /// Removes an <c><a>IndexField</a></c> from the search domain. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html"
        /// target="_blank">Configuring Index Fields</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField service method.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteIndexField">REST API Reference for DeleteIndexField Operation</seealso>
        DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndexField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndexField
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteIndexField">REST API Reference for DeleteIndexField Operation</seealso>
        IAsyncResult BeginDeleteIndexField(DeleteIndexFieldRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIndexField operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndexField.</param>
        /// 
        /// <returns>Returns a  DeleteIndexFieldResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteIndexField">REST API Reference for DeleteIndexField Operation</seealso>
        DeleteIndexFieldResponse EndDeleteIndexField(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSuggester


        /// <summary>
        /// Deletes a suggester. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html"
        /// target="_blank">Getting Search Suggestions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuggester service method.</param>
        /// 
        /// <returns>The response from the DeleteSuggester service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteSuggester">REST API Reference for DeleteSuggester Operation</seealso>
        DeleteSuggesterResponse DeleteSuggester(DeleteSuggesterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSuggester operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuggester operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSuggester
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteSuggester">REST API Reference for DeleteSuggester Operation</seealso>
        IAsyncResult BeginDeleteSuggester(DeleteSuggesterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSuggester operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSuggester.</param>
        /// 
        /// <returns>Returns a  DeleteSuggesterResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DeleteSuggester">REST API Reference for DeleteSuggester Operation</seealso>
        DeleteSuggesterResponse EndDeleteSuggester(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAnalysisSchemes


        /// <summary>
        /// Gets the analysis schemes configured for a domain. An analysis scheme defines language-specific
        /// text processing options for a <c>text</c> field. Can be limited to specific analysis
        /// schemes by name. By default, shows all analysis schemes and includes any pending changes
        /// to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// target="_blank">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisSchemes service method.</param>
        /// 
        /// <returns>The response from the DescribeAnalysisSchemes service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeAnalysisSchemes">REST API Reference for DescribeAnalysisSchemes Operation</seealso>
        DescribeAnalysisSchemesResponse DescribeAnalysisSchemes(DescribeAnalysisSchemesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnalysisSchemes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisSchemes operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnalysisSchemes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeAnalysisSchemes">REST API Reference for DescribeAnalysisSchemes Operation</seealso>
        IAsyncResult BeginDescribeAnalysisSchemes(DescribeAnalysisSchemesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnalysisSchemes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnalysisSchemes.</param>
        /// 
        /// <returns>Returns a  DescribeAnalysisSchemesResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeAnalysisSchemes">REST API Reference for DescribeAnalysisSchemes Operation</seealso>
        DescribeAnalysisSchemesResponse EndDescribeAnalysisSchemes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAvailabilityOptions


        /// <summary>
        /// Gets the availability options configured for a domain. By default, shows the configuration
        /// with any pending changes. Set the <c>Deployed</c> option to <c>true</c> to show the
        /// active configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html"
        /// target="_blank">Configuring Availability Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeAvailabilityOptions">REST API Reference for DescribeAvailabilityOptions Operation</seealso>
        DescribeAvailabilityOptionsResponse DescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAvailabilityOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeAvailabilityOptions">REST API Reference for DescribeAvailabilityOptions Operation</seealso>
        IAsyncResult BeginDescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAvailabilityOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a  DescribeAvailabilityOptionsResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeAvailabilityOptions">REST API Reference for DescribeAvailabilityOptions Operation</seealso>
        DescribeAvailabilityOptionsResponse EndDescribeAvailabilityOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomainEndpointOptions


        /// <summary>
        /// Returns the domain's endpoint options, specifically whether all requests to the domain
        /// must arrive over HTTPS. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-domain-endpoint-options.html"
        /// target="_blank">Configuring Domain Endpoint Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainEndpointOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeDomainEndpointOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeDomainEndpointOptions">REST API Reference for DescribeDomainEndpointOptions Operation</seealso>
        DescribeDomainEndpointOptionsResponse DescribeDomainEndpointOptions(DescribeDomainEndpointOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainEndpointOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainEndpointOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomainEndpointOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeDomainEndpointOptions">REST API Reference for DescribeDomainEndpointOptions Operation</seealso>
        IAsyncResult BeginDescribeDomainEndpointOptions(DescribeDomainEndpointOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomainEndpointOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomainEndpointOptions.</param>
        /// 
        /// <returns>Returns a  DescribeDomainEndpointOptionsResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeDomainEndpointOptions">REST API Reference for DescribeDomainEndpointOptions Operation</seealso>
        DescribeDomainEndpointOptionsResponse EndDescribeDomainEndpointOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomains


        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default. To get the number of searchable documents
        /// in a domain, use the console or submit a <c>matchall</c> request to your domain's
        /// search endpoint: <c>q=matchall&amp;amp;q.parser=structured&amp;amp;size=0</c>. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-domain-info.html"
        /// target="_blank">Getting Information about a Search Domain</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        DescribeDomainsResponse DescribeDomains();

        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default. To get the number of searchable documents
        /// in a domain, use the console or submit a <c>matchall</c> request to your domain's
        /// search endpoint: <c>q=matchall&amp;amp;q.parser=structured&amp;amp;size=0</c>. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-domain-info.html"
        /// target="_blank">Getting Information about a Search Domain</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains service method.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        IAsyncResult BeginDescribeDomains(DescribeDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomains.</param>
        /// 
        /// <returns>Returns a  DescribeDomainsResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        DescribeDomainsResponse EndDescribeDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExpressions


        /// <summary>
        /// Gets the expressions configured for the search domain. Can be limited to specific
        /// expressions by name. By default, shows all expressions and includes any pending changes
        /// to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
        /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExpressions service method.</param>
        /// 
        /// <returns>The response from the DescribeExpressions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeExpressions">REST API Reference for DescribeExpressions Operation</seealso>
        DescribeExpressionsResponse DescribeExpressions(DescribeExpressionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExpressions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExpressions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExpressions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeExpressions">REST API Reference for DescribeExpressions Operation</seealso>
        IAsyncResult BeginDescribeExpressions(DescribeExpressionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExpressions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExpressions.</param>
        /// 
        /// <returns>Returns a  DescribeExpressionsResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeExpressions">REST API Reference for DescribeExpressions Operation</seealso>
        DescribeExpressionsResponse EndDescribeExpressions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIndexFields


        /// <summary>
        /// Gets information about the index fields configured for the search domain. Can be limited
        /// to specific fields by name. By default, shows all fields and includes any pending
        /// changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show
        /// the active configuration and exclude pending changes. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-domain-info.html"
        /// target="_blank">Getting Domain Information</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields service method.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeIndexFields">REST API Reference for DescribeIndexFields Operation</seealso>
        DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndexFields operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIndexFields
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeIndexFields">REST API Reference for DescribeIndexFields Operation</seealso>
        IAsyncResult BeginDescribeIndexFields(DescribeIndexFieldsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIndexFields operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIndexFields.</param>
        /// 
        /// <returns>Returns a  DescribeIndexFieldsResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeIndexFields">REST API Reference for DescribeIndexFields Operation</seealso>
        DescribeIndexFieldsResponse EndDescribeIndexFields(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeScalingParameters


        /// <summary>
        /// Gets the scaling parameters configured for a domain. A domain's scaling parameters
        /// specify the desired search instance type and replication count. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html"
        /// target="_blank">Configuring Scaling Options</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingParameters service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeScalingParameters">REST API Reference for DescribeScalingParameters Operation</seealso>
        DescribeScalingParametersResponse DescribeScalingParameters(DescribeScalingParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingParameters operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeScalingParameters">REST API Reference for DescribeScalingParameters Operation</seealso>
        IAsyncResult BeginDescribeScalingParameters(DescribeScalingParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingParameters.</param>
        /// 
        /// <returns>Returns a  DescribeScalingParametersResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeScalingParameters">REST API Reference for DescribeScalingParameters Operation</seealso>
        DescribeScalingParametersResponse EndDescribeScalingParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeServiceAccessPolicies


        /// <summary>
        /// Gets information about the access policies that control access to the domain's document
        /// and search endpoints. By default, shows the configuration with any pending changes.
        /// Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and
        /// exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"
        /// target="_blank">Configuring Access for a Search Domain</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeServiceAccessPolicies">REST API Reference for DescribeServiceAccessPolicies Operation</seealso>
        DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceAccessPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeServiceAccessPolicies">REST API Reference for DescribeServiceAccessPolicies Operation</seealso>
        IAsyncResult BeginDescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeServiceAccessPoliciesResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeServiceAccessPolicies">REST API Reference for DescribeServiceAccessPolicies Operation</seealso>
        DescribeServiceAccessPoliciesResponse EndDescribeServiceAccessPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSuggesters


        /// <summary>
        /// Gets the suggesters configured for a domain. A suggester enables you to display possible
        /// matches before users finish typing their queries. Can be limited to specific suggesters
        /// by name. By default, shows all suggesters and includes any pending changes to the
        /// configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration
        /// and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html"
        /// target="_blank">Getting Search Suggestions</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSuggesters service method.</param>
        /// 
        /// <returns>The response from the DescribeSuggesters service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeSuggesters">REST API Reference for DescribeSuggesters Operation</seealso>
        DescribeSuggestersResponse DescribeSuggesters(DescribeSuggestersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSuggesters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSuggesters operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSuggesters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeSuggesters">REST API Reference for DescribeSuggesters Operation</seealso>
        IAsyncResult BeginDescribeSuggesters(DescribeSuggestersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSuggesters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSuggesters.</param>
        /// 
        /// <returns>Returns a  DescribeSuggestersResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/DescribeSuggesters">REST API Reference for DescribeSuggesters Operation</seealso>
        DescribeSuggestersResponse EndDescribeSuggesters(IAsyncResult asyncResult);

        #endregion
        
        #region  IndexDocuments


        /// <summary>
        /// Tells the search domain to start indexing its documents using the latest indexing
        /// options. This operation must be invoked to activate options whose <a>OptionStatus</a>
        /// is <c>RequiresIndexDocuments</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments service method.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/IndexDocuments">REST API Reference for IndexDocuments Operation</seealso>
        IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the IndexDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIndexDocuments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/IndexDocuments">REST API Reference for IndexDocuments Operation</seealso>
        IAsyncResult BeginIndexDocuments(IndexDocumentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  IndexDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIndexDocuments.</param>
        /// 
        /// <returns>Returns a  IndexDocumentsResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/IndexDocuments">REST API Reference for IndexDocuments Operation</seealso>
        IndexDocumentsResponse EndIndexDocuments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomainNames


        /// <summary>
        /// Lists all search domains owned by an account.
        /// </summary>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        ListDomainNamesResponse ListDomainNames();

        /// <summary>
        /// Lists all search domains owned by an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        IAsyncResult BeginListDomainNames(ListDomainNamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainNames.</param>
        /// 
        /// <returns>Returns a  ListDomainNamesResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        ListDomainNamesResponse EndListDomainNames(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAvailabilityOptions


        /// <summary>
        /// Configures the availability options for a domain. Enabling the Multi-AZ option expands
        /// an Amazon CloudSearch domain to an additional Availability Zone in the same Region
        /// to increase fault tolerance in the event of a service disruption. Changes to the Multi-AZ
        /// option can take about half an hour to become active. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html"
        /// target="_blank">Configuring Availability Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateAvailabilityOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateAvailabilityOptions">REST API Reference for UpdateAvailabilityOptions Operation</seealso>
        UpdateAvailabilityOptionsResponse UpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAvailabilityOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAvailabilityOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateAvailabilityOptions">REST API Reference for UpdateAvailabilityOptions Operation</seealso>
        IAsyncResult BeginUpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAvailabilityOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a  UpdateAvailabilityOptionsResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateAvailabilityOptions">REST API Reference for UpdateAvailabilityOptions Operation</seealso>
        UpdateAvailabilityOptionsResponse EndUpdateAvailabilityOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomainEndpointOptions


        /// <summary>
        /// Updates the domain's endpoint options, specifically whether all requests to the domain
        /// must arrive over HTTPS. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-domain-endpoint-options.html"
        /// target="_blank">Configuring Domain Endpoint Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEndpointOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainEndpointOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateDomainEndpointOptions">REST API Reference for UpdateDomainEndpointOptions Operation</seealso>
        UpdateDomainEndpointOptionsResponse UpdateDomainEndpointOptions(UpdateDomainEndpointOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainEndpointOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEndpointOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainEndpointOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateDomainEndpointOptions">REST API Reference for UpdateDomainEndpointOptions Operation</seealso>
        IAsyncResult BeginUpdateDomainEndpointOptions(UpdateDomainEndpointOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainEndpointOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainEndpointOptions.</param>
        /// 
        /// <returns>Returns a  UpdateDomainEndpointOptionsResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateDomainEndpointOptions">REST API Reference for UpdateDomainEndpointOptions Operation</seealso>
        UpdateDomainEndpointOptionsResponse EndUpdateDomainEndpointOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateScalingParameters


        /// <summary>
        /// Configures scaling parameters for a domain. A domain's scaling parameters specify
        /// the desired search instance type and replication count. Amazon CloudSearch will still
        /// automatically scale your domain based on the volume of data and traffic, but not below
        /// the desired instance type and replication count. If the Multi-AZ option is enabled,
        /// these values control the resources used per Availability Zone. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html"
        /// target="_blank">Configuring Scaling Options</a> in the <i>Amazon CloudSearch Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScalingParameters service method.</param>
        /// 
        /// <returns>The response from the UpdateScalingParameters service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateScalingParameters">REST API Reference for UpdateScalingParameters Operation</seealso>
        UpdateScalingParametersResponse UpdateScalingParameters(UpdateScalingParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScalingParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScalingParameters operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScalingParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateScalingParameters">REST API Reference for UpdateScalingParameters Operation</seealso>
        IAsyncResult BeginUpdateScalingParameters(UpdateScalingParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScalingParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScalingParameters.</param>
        /// 
        /// <returns>Returns a  UpdateScalingParametersResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateScalingParameters">REST API Reference for UpdateScalingParameters Operation</seealso>
        UpdateScalingParametersResponse EndUpdateScalingParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServiceAccessPolicies


        /// <summary>
        /// Configures the access rules that control access to the domain's document and search
        /// endpoints. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"
        /// target="_blank"> Configuring Access for an Amazon CloudSearch Domain</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/" target="_blank">Service
        /// Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch.Model.ValidationException">
        /// The request was rejected because it has invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateServiceAccessPolicies">REST API Reference for UpdateServiceAccessPolicies Operation</seealso>
        UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceAccessPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateServiceAccessPolicies">REST API Reference for UpdateServiceAccessPolicies Operation</seealso>
        IAsyncResult BeginUpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a  UpdateServiceAccessPoliciesResult from CloudSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearch-2013-01-01/UpdateServiceAccessPolicies">REST API Reference for UpdateServiceAccessPolicies Operation</seealso>
        UpdateServiceAccessPoliciesResponse EndUpdateServiceAccessPolicies(IAsyncResult asyncResult);

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