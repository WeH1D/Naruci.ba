using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using IdentityModel.Client;
using NaruciBa.Model;
using Newtonsoft.Json;

namespace NaruciBa.WinUI
{
    public class APIService
    {
        private string _route;
        string _url = Properties.Settings.Default.ApiURL;
        private HttpClient _apiClient = new HttpClient();
        private TokenResponse _token = null;

        public APIService(string route)
        {
            _route = route;
        }

        //TODO: na loginu spremiti token u staticku varijablu, ne pozivati ga svaki put
        public async Task<TokenResponse> getToken()
        {
            if (_token == null)
            {
                var disco = await _apiClient.GetDiscoveryDocumentAsync(Properties.Settings.Default.IdentityServerApi);
                _token = await _apiClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
                {
                    Address = disco.TokenEndpoint,

                    ClientId = "WinApp",
                    ClientSecret = "WinAppPassword",
                    Scope = "NaruciBaApi"
                });

                if (_token.IsError)
                {
                    throw new Exception("Connection error");
                }
            }

            return _token;
        }


        //TODO: FINISH THE REST OF APISERVICe
        public async Task<T> Get<T>(object request = null)
        {
            TokenResponse token = await getToken();

            var url = $"{_url}/{_route}";
            if (request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }

            _apiClient.SetBearerToken(token.AccessToken);

            var response = await _apiClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Connection error");
            }

            var content = await response.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<T>(content);

            return obj;
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_url}/{_route}/{id}";
            var result = await url.GetJsonAsync<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_url}/{_route}";
            var result = await url.PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_url}/{_route}/{id}";
            var result = await url.PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
