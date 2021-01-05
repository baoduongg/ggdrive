using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ggdrive
{
    public class GoogleServices
    {
        public static readonly string ClientId = "334325008766-fo1fl6hhn4dpsbah751v3shaatst600e.apps.googleusercontent.com";
        public static readonly string ClientSecret = "WCYF3hM7rcFCmsreK0EzIoCv";
        string Uri = "https://www.googleapis.com/auth/drive";
        public GoogleServices()
        {
        }
        public async Task<string> GetAccessToken(string code)
        {
            var requestUrl =
              "https://www.googleapis.com/oauth2/v4/token"
              + "?code=" + code
              + "&client_id=" + ClientId
              //+ "&client_secret=" + ClientSecret
              + "&redirect_uri=" + Uri
              + "&grant_type=authorization_code";

            var httpClient = new HttpClient();

            var response = await httpClient.PostAsync(requestUrl, null);

            var json = await response.Content.ReadAsStringAsync();

            var accessToken = JsonConvert.DeserializeObject<JObject>(json).Value<string>("access_token");

            return accessToken;
        }
    }
}
