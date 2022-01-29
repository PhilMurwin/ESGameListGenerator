using ESGameListGenerator2.Models.API;
using RestSharp;

namespace ESGameListGenerator2.TheGamesDBApi
{
    public class GamesDBAPI : BaseGamesDBAPI
    {
        public GamesDBAPI( string apiKey ):base( apiKey )
        { 
        }

        public APIGame ByGameName( string gameName )
        {
            var apiMethod = "/v1/Games/ByGameName";
            var request = BuildGetRequest(apiMethod);

            request.AddQueryParameter("name", gameName);

            var response = GetAPIResponse<APIGame>(request);

            var errMsg = $"GamesDBAPI.ByGameName StatusCode: {response.StatusCode}";
            CheckResponseForErrors(response, errMsg);

            return response.Data;
        }

        public void GetGameImage( int gameID )
        {
            var apiMethod = "/v1/Games/Images";

            var request = BuildGetRequest(apiMethod);
            request.AddQueryParameter("game_id", gameID);

            //GetAPIResponse<>
        }

        public List<APIPlatformSkinny> GetPlatforms()
        {
            var apiMethod = "/v1/Platforms";

            var request = BuildGetRequest(apiMethod);

            var response = GetAPIResponse<List<APIPlatformSkinny>>(request);

            var errMsg = $"GamesDBAPI.GetPlatforms StatusCode: {response.StatusCode}";
            CheckResponseForErrors(response, errMsg);

            return response.Data;
        }

        private void CheckResponseForErrors( RestResponse response, string errMsg )
        {
            if (response.ErrorException != null || response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(errMsg);
            }
        }
    }
}
