/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace sib_api_v3_sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProcessApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Return the informations for a process
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">Id of the process</param>
        /// <returns>GetProcess</returns>
        GetProcess GetProcess (long? processId);

        /// <summary>
        /// Return the informations for a process
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">Id of the process</param>
        /// <returns>ApiResponse of GetProcess</returns>
        ApiResponse<GetProcess> GetProcessWithHttpInfo (long? processId);
        /// <summary>
        /// Return all the processes for your account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number limitation for the result returned (optional, default to 10)</param>
        /// <param name="offset">Beginning point in the list to retrieve from. (optional, default to 0)</param>
        /// <returns>GetProcesses</returns>
        GetProcesses GetProcesses (long? limit = null, long? offset = null);

        /// <summary>
        /// Return all the processes for your account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number limitation for the result returned (optional, default to 10)</param>
        /// <param name="offset">Beginning point in the list to retrieve from. (optional, default to 0)</param>
        /// <returns>ApiResponse of GetProcesses</returns>
        ApiResponse<GetProcesses> GetProcessesWithHttpInfo (long? limit = null, long? offset = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Return the informations for a process
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">Id of the process</param>
        /// <returns>Task of GetProcess</returns>
        System.Threading.Tasks.Task<GetProcess> GetProcessAsync (long? processId);

        /// <summary>
        /// Return the informations for a process
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">Id of the process</param>
        /// <returns>Task of ApiResponse (GetProcess)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetProcess>> GetProcessAsyncWithHttpInfo (long? processId);
        /// <summary>
        /// Return all the processes for your account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number limitation for the result returned (optional, default to 10)</param>
        /// <param name="offset">Beginning point in the list to retrieve from. (optional, default to 0)</param>
        /// <returns>Task of GetProcesses</returns>
        System.Threading.Tasks.Task<GetProcesses> GetProcessesAsync (long? limit = null, long? offset = null);

        /// <summary>
        /// Return all the processes for your account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number limitation for the result returned (optional, default to 10)</param>
        /// <param name="offset">Beginning point in the list to retrieve from. (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (GetProcesses)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetProcesses>> GetProcessesAsyncWithHttpInfo (long? limit = null, long? offset = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProcessApi : IProcessApi
    {
        private sib_api_v3_sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProcessApi(String basePath)
        {
            this.Configuration = new sib_api_v3_sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = sib_api_v3_sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProcessApi(sib_api_v3_sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = sib_api_v3_sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = sib_api_v3_sdk.Client.Configuration.DefaultExceptionFactory;
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
        public sib_api_v3_sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public sib_api_v3_sdk.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Return the informations for a process 
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">Id of the process</param>
        /// <returns>GetProcess</returns>
        public GetProcess GetProcess (long? processId)
        {
             ApiResponse<GetProcess> localVarResponse = GetProcessWithHttpInfo(processId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Return the informations for a process 
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">Id of the process</param>
        /// <returns>ApiResponse of GetProcess</returns>
        public ApiResponse< GetProcess > GetProcessWithHttpInfo (long? processId)
        {
            // verify the required parameter 'processId' is set
            if (processId == null)
                throw new ApiException(400, "Missing required parameter 'processId' when calling ProcessApi->GetProcess");

            var localVarPath = "/processes/{processId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (processId != null) localVarPathParams.Add("processId", this.Configuration.ApiClient.ParameterToString(processId)); // path parameter

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }
            // authentication (partner-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("partner-key")))
            {
                localVarHeaderParams["partner-key"] = this.Configuration.GetApiKeyWithPrefix("partner-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProcess", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetProcess) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetProcess)));
        }

        /// <summary>
        /// Return the informations for a process 
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">Id of the process</param>
        /// <returns>Task of GetProcess</returns>
        public async System.Threading.Tasks.Task<GetProcess> GetProcessAsync (long? processId)
        {
             ApiResponse<GetProcess> localVarResponse = await GetProcessAsyncWithHttpInfo(processId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Return the informations for a process 
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processId">Id of the process</param>
        /// <returns>Task of ApiResponse (GetProcess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetProcess>> GetProcessAsyncWithHttpInfo (long? processId)
        {
            // verify the required parameter 'processId' is set
            if (processId == null)
                throw new ApiException(400, "Missing required parameter 'processId' when calling ProcessApi->GetProcess");

            var localVarPath = "/processes/{processId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (processId != null) localVarPathParams.Add("processId", this.Configuration.ApiClient.ParameterToString(processId)); // path parameter

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }
            // authentication (partner-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("partner-key")))
            {
                localVarHeaderParams["partner-key"] = this.Configuration.GetApiKeyWithPrefix("partner-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProcess", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetProcess) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetProcess)));
        }

        /// <summary>
        /// Return all the processes for your account 
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number limitation for the result returned (optional, default to 10)</param>
        /// <param name="offset">Beginning point in the list to retrieve from. (optional, default to 0)</param>
        /// <returns>GetProcesses</returns>
        public GetProcesses GetProcesses (long? limit = null, long? offset = null)
        {
             ApiResponse<GetProcesses> localVarResponse = GetProcessesWithHttpInfo(limit, offset);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Return all the processes for your account 
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number limitation for the result returned (optional, default to 10)</param>
        /// <param name="offset">Beginning point in the list to retrieve from. (optional, default to 0)</param>
        /// <returns>ApiResponse of GetProcesses</returns>
        public ApiResponse< GetProcesses > GetProcessesWithHttpInfo (long? limit = null, long? offset = null)
        {

            var localVarPath = "/processes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }
            // authentication (partner-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("partner-key")))
            {
                localVarHeaderParams["partner-key"] = this.Configuration.GetApiKeyWithPrefix("partner-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProcesses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetProcesses>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetProcesses) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetProcesses)));
        }

        /// <summary>
        /// Return all the processes for your account 
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number limitation for the result returned (optional, default to 10)</param>
        /// <param name="offset">Beginning point in the list to retrieve from. (optional, default to 0)</param>
        /// <returns>Task of GetProcesses</returns>
        public async System.Threading.Tasks.Task<GetProcesses> GetProcessesAsync (long? limit = null, long? offset = null)
        {
             ApiResponse<GetProcesses> localVarResponse = await GetProcessesAsyncWithHttpInfo(limit, offset);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Return all the processes for your account 
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number limitation for the result returned (optional, default to 10)</param>
        /// <param name="offset">Beginning point in the list to retrieve from. (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (GetProcesses)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetProcesses>> GetProcessesAsyncWithHttpInfo (long? limit = null, long? offset = null)
        {

            var localVarPath = "/processes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }
            // authentication (partner-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("partner-key")))
            {
                localVarHeaderParams["partner-key"] = this.Configuration.GetApiKeyWithPrefix("partner-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProcesses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetProcesses>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetProcesses) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetProcesses)));
        }

    }
}
