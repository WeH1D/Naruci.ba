using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using NaruciBa.Model;

namespace NaruciBa.WinUI
{
    public class APIService
    {
        private string _route;
        string _url = Properties.Settings.Default.ApiURL;
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object request = null)
        {
            var url = $"{_url}/{_route}";
            if(request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }       
            var result = await url.GetJsonAsync<T>();
            return result;
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
