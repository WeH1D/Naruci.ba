using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using IdentityModel.Client;
using NaruciBa.Model;
using NaruciBa.WinUI.Services;
using Newtonsoft.Json;

namespace NaruciBa.WinUI
{
    public class APIService
    {
        private string _route;
        string _url = Properties.Settings.Default.ApiURL;
        private HttpClient _apiClient = new HttpClient();

        public APIService(string route)
        {
            _route = route;
        }

        // TODO: Find a way to check for access token validtiy before making the api call
        // store hashed password and username in Properties.defaults 
       
        public async Task<T> Get<T>(object request = null)
        {
            var url = $"{_url}/{_route}";
            if (request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }

            _apiClient.SetBearerToken(Properties.Settings.Default.AccessToken);

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

            _apiClient.SetBearerToken(Properties.Settings.Default.AccessToken);

            var response = await _apiClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Connection error");
            }

            var content = await response.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<T>(content);

            return obj;
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_url}/{_route}";

            _apiClient.SetBearerToken(Properties.Settings.Default.AccessToken);

            var response = await _apiClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Connection error");
            }

            var content = await response.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<T>(content);

            return obj;
        }
        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_url}/{_route}/{id}";

            _apiClient.SetBearerToken(Properties.Settings.Default.AccessToken);

            var response = await _apiClient.PutAsync(url, new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Connection error");
            }

            var content = await response.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<T>(content);

            return obj;
        }
    }
}
