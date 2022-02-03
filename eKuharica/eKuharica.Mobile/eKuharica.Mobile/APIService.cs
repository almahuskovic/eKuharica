using eKuharica.Model.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Flurl.Http;
using System.Threading.Tasks;

namespace eKuharica.Mobile
{
    public class APIService
    {
        private string _route = string.Empty;

        public static string Username { get; set; }
        public static string Password { get; set; }
#if DEBUG
        private string _apiUrl = "http://localhost:5000";
#endif
#if RELEASE
#endif
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object searchRequest = null)
        {
            var url = $"{_apiUrl}/{_route}";

            if (searchRequest != null)
            {
                url += "?";
                url += await searchRequest?.ToQueryString();
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";
            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<bool> Delete<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).DeleteAsync();
            return result.StatusCode == 200;
        }

        public async Task<T> GetRecommended<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/Recommend/{id}";
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }
    }
}
