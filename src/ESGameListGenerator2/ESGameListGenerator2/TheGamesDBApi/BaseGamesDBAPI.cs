using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESGameListGenerator2.TheGamesDBApi
{
    public class BaseGamesDBAPI
    {
        private const string BASEURL = "https://api.thegamesdb.net";

        protected ILogger _logger;
        protected RestClient _restClient;
        protected string _apiKey;

        public BaseGamesDBAPI( string apiKey )
        {
            _apiKey = apiKey;
            _logger = LogManager.GetCurrentClassLogger();

            _restClient = new RestClient(BASEURL);
        }

        protected RestRequest BuildGetRequest( string apiMethod )
        {
            var request = new RestRequest(apiMethod, Method.Get);
            request.AddHeader("Accept", "application/json");
            request.AddQueryParameter("apiKey", _apiKey);
            return request;
        }

        protected RestResponse<T> GetAPIResponse<T>( RestRequest request )
        {
            // Create a Task<RestResponse<T>> object
            var apiTask = _restClient.ExecuteAsync<T>(request);

            // Return the response synchronously
            return apiTask.Result;
        }
    }
}
