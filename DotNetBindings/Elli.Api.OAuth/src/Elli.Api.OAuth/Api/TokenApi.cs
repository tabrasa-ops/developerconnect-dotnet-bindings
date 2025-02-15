/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/

/* 
 * OAuth2 Token Service
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.4.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Elli.Api.OAuth.Client;
using Elli.Api.OAuth.Model;

namespace Elli.Api.OAuth.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokenApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.OAuth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">password, authorization_code, client_credentials, urn:elli:params:oauth:grant-type:encompass-bearer</param>
        /// <param name="username">For password grant (optional)</param>
        /// <param name="password">For password grant (optional)</param>
        /// <param name="scope">A valid scope (optional)</param>
        /// <param name="redirectUri">For auth code grant (optional)</param>
        /// <param name="code">For auth code grant (optional)</param>
        /// <param name="session">For grant_type &#x3D; urn:elli:params:oauth:grant-type:encompass-bearer (optional)</param>
        /// <returns>TokenIssuance</returns>
        TokenIssuance GenerateToken (string grantType, string username = null, string password = null, string scope = null, string redirectUri = null, string code = null, string session = null, string instanceId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.OAuth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">password, authorization_code, client_credentials, urn:elli:params:oauth:grant-type:encompass-bearer</param>
        /// <param name="username">For password grant (optional)</param>
        /// <param name="password">For password grant (optional)</param>
        /// <param name="scope">A valid scope (optional)</param>
        /// <param name="redirectUri">For auth code grant (optional)</param>
        /// <param name="code">For auth code grant (optional)</param>
        /// <param name="session">For grant_type &#x3D; urn:elli:params:oauth:grant-type:encompass-bearer (optional)</param>
        /// <returns>ApiResponse of TokenIssuance</returns>
        ApiResponse<TokenIssuance> GenerateTokenWithHttpInfo (string grantType, string username = null, string password = null, string scope = null, string redirectUri = null, string code = null, string session = null, string instanceId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.OAuth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">password, authorization_code, client_credentials, urn:elli:params:oauth:grant-type:encompass-bearer</param>
        /// <param name="username">For password grant (optional)</param>
        /// <param name="password">For password grant (optional)</param>
        /// <param name="scope">A valid scope (optional)</param>
        /// <param name="redirectUri">For auth code grant (optional)</param>
        /// <param name="code">For auth code grant (optional)</param>
        /// <param name="session">For grant_type &#x3D; urn:elli:params:oauth:grant-type:encompass-bearer (optional)</param>
        /// <returns>Task of TokenIssuance</returns>
        System.Threading.Tasks.Task<TokenIssuance> GenerateTokenAsync (string grantType, string username = null, string password = null, string scope = null, string redirectUri = null, string code = null, string session = null, string instanceId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.OAuth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">password, authorization_code, client_credentials, urn:elli:params:oauth:grant-type:encompass-bearer</param>
        /// <param name="username">For password grant (optional)</param>
        /// <param name="password">For password grant (optional)</param>
        /// <param name="scope">A valid scope (optional)</param>
        /// <param name="redirectUri">For auth code grant (optional)</param>
        /// <param name="code">For auth code grant (optional)</param>
        /// <param name="session">For grant_type &#x3D; urn:elli:params:oauth:grant-type:encompass-bearer (optional)</param>
        /// <returns>Task of ApiResponse (TokenIssuance)</returns>
        System.Threading.Tasks.Task<ApiResponse<TokenIssuance>> GenerateTokenAsyncWithHttpInfo (string grantType, string username = null, string password = null, string scope = null, string redirectUri = null, string code = null, string session = null, string instanceId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TokenApi : ITokenApi
    {
        private Elli.Api.OAuth.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokenApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Elli.Api.OAuth.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokenApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Elli.Api.OAuth.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Elli.Api.OAuth.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.OAuth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">password, authorization_code, client_credentials, urn:elli:params:oauth:grant-type:encompass-bearer</param>
        /// <param name="username">For password grant (optional)</param>
        /// <param name="password">For password grant (optional)</param>
        /// <param name="scope">A valid scope (optional)</param>
        /// <param name="redirectUri">For auth code grant (optional)</param>
        /// <param name="code">For auth code grant (optional)</param>
        /// <param name="session">For grant_type &#x3D; urn:elli:params:oauth:grant-type:encompass-bearer (optional)</param>
        /// <returns>TokenIssuance</returns>
        public TokenIssuance GenerateToken (string grantType, string username = null, string password = null, string scope = null, string redirectUri = null, string code = null, string session = null, string instanceId = null)
        {
             ApiResponse<TokenIssuance> localVarResponse = GenerateTokenWithHttpInfo(grantType, username, password, scope, redirectUri, code, session, instanceId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.OAuth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">password, authorization_code, client_credentials, urn:elli:params:oauth:grant-type:encompass-bearer</param>
        /// <param name="username">For password grant (optional)</param>
        /// <param name="password">For password grant (optional)</param>
        /// <param name="scope">A valid scope (optional)</param>
        /// <param name="redirectUri">For auth code grant (optional)</param>
        /// <param name="code">For auth code grant (optional)</param>
        /// <param name="session">For grant_type &#x3D; urn:elli:params:oauth:grant-type:encompass-bearer (optional)</param>
        /// <returns>ApiResponse of TokenIssuance</returns>
        public ApiResponse< TokenIssuance > GenerateTokenWithHttpInfo (string grantType, string username = null, string password = null, string scope = null, string redirectUri = null, string code = null, string session = null, string instanceId = null)
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling TokenApi->GenerateToken");

            var localVarPath = "/oauth2/v1/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (username != null) localVarFormParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (scope != null) localVarFormParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // form parameter
            if (redirectUri != null) localVarFormParams.Add("redirect_uri", Configuration.ApiClient.ParameterToString(redirectUri)); // form parameter
            if (code != null) localVarFormParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // form parameter
            if (session != null) localVarFormParams.Add("session", Configuration.ApiClient.ParameterToString(session)); // form parameter
            if (instanceId != null) localVarFormParams.Add("instance_id", Configuration.ApiClient.ParameterToString(instanceId)); // form parameter

            // authentication (ClientCredential) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                if (grantType.Equals("client_credentials"))
                {
                    localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(Configuration.Username)); // form parameter
                    localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(Configuration.Password)); // form parameter
                }
                else
                {
                    localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
                }
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GenerateToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenIssuance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenIssuance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenIssuance)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.OAuth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">password, authorization_code, client_credentials, urn:elli:params:oauth:grant-type:encompass-bearer</param>
        /// <param name="username">For password grant (optional)</param>
        /// <param name="password">For password grant (optional)</param>
        /// <param name="scope">A valid scope (optional)</param>
        /// <param name="redirectUri">For auth code grant (optional)</param>
        /// <param name="code">For auth code grant (optional)</param>
        /// <param name="session">For grant_type &#x3D; urn:elli:params:oauth:grant-type:encompass-bearer (optional)</param>
        /// <returns>Task of TokenIssuance</returns>
        public async System.Threading.Tasks.Task<TokenIssuance> GenerateTokenAsync (string grantType, string username = null, string password = null, string scope = null, string redirectUri = null, string code = null, string session = null, string instanceId = null)
        {
             ApiResponse<TokenIssuance> localVarResponse = await GenerateTokenAsyncWithHttpInfo(grantType, username, password, scope, redirectUri, code, session, instanceId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.OAuth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">password, authorization_code, client_credentials, urn:elli:params:oauth:grant-type:encompass-bearer</param>
        /// <param name="username">For password grant (optional)</param>
        /// <param name="password">For password grant (optional)</param>
        /// <param name="scope">A valid scope (optional)</param>
        /// <param name="redirectUri">For auth code grant (optional)</param>
        /// <param name="code">For auth code grant (optional)</param>
        /// <param name="session">For grant_type &#x3D; urn:elli:params:oauth:grant-type:encompass-bearer (optional)</param>
        /// <returns>Task of ApiResponse (TokenIssuance)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TokenIssuance>> GenerateTokenAsyncWithHttpInfo (string grantType, string username = null, string password = null, string scope = null, string redirectUri = null, string code = null, string session = null, string instanceId = null)
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling TokenApi->GenerateToken");

            var localVarPath = "/oauth2/v1/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (username != null) localVarFormParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (scope != null) localVarFormParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // form parameter
            if (redirectUri != null) localVarFormParams.Add("redirect_uri", Configuration.ApiClient.ParameterToString(redirectUri)); // form parameter
            if (code != null) localVarFormParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // form parameter
            if (session != null) localVarFormParams.Add("session", Configuration.ApiClient.ParameterToString(session)); // form parameter
            if (instanceId != null) localVarFormParams.Add("instance_id", Configuration.ApiClient.ParameterToString(instanceId)); // form parameter

            // authentication (ClientCredential) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                if (grantType.Equals("client_credentials"))
                {
                    localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(Configuration.Username)); // form parameter
                    localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(Configuration.Password)); // form parameter
                }
                else
                {
                    localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
                }
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GenerateToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenIssuance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenIssuance) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenIssuance)));
        }

    }
}
