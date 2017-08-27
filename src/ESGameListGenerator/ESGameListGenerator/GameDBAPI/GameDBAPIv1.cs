using RestSharp;
using ESGameListGenerator.Models.GameDBAPI;
using System.Net;
using System;
using System.IO;

namespace ESGameListGenerator.GameDBAPI
{
    public static class GameDBAPIv1
    {
        private const string baseURL = "http://thegamesdb.net/api/";

        public static GameData GetGame(string name, string platform = null )
        {
            var getGameURL = baseURL + "/GetGame.php";
            var getGameAPI = new RestSharp.RestClient( getGameURL );
            var apiRequest = new RestSharp.RestRequest( Method.POST );
            apiRequest.AddQueryParameter( "name", name );

            if ( !string.IsNullOrEmpty( platform ) )
            {
                apiRequest.AddQueryParameter( "platform", platform );
            }

            apiRequest.RequestFormat = DataFormat.Xml;

            var response = getGameAPI.Execute( apiRequest );
            var gameData =  ProcessXML.ParseXMLToModel<GameData>( response.Content );

            return gameData;
        }

        public static void GetFrontImageFile( string uri, string fileName )
        {
            var request = (HttpWebRequest)WebRequest.Create( uri );
            var response = (HttpWebResponse)request.GetResponse();

            // Check that the remote file was found. The ContentType
            // check is performed since a request for a non-existent
            // image file might be redirected to a 404-page, which would
            // yield the StatusCode "OK", even though the image was not
            // found.
            if ( ( response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect ) &&
                response.ContentType.StartsWith( "image", StringComparison.OrdinalIgnoreCase ) )
            {

                // if the remote file was found, download oit
                using ( var inputStream = response.GetResponseStream() )
                using ( var outputStream = File.OpenWrite( fileName ) )
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read( buffer, 0, buffer.Length );
                        outputStream.Write( buffer, 0, bytesRead );
                    } while ( bytesRead != 0 );
                }
            }
        }
    }
}
