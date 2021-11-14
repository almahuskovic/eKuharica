using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using eKuharica.Model.Extensions;

namespace eKuharica.WinUI
{
    public class APIService
    {
        private string _route = string.Empty;
            
        public static string Username { get; set; }
        public static string Password { get; set; }

        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object searchRequest = null)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            
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
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<bool> Delete<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).DeleteAsync();
            return result.StatusCode==200;
        }
    }
}
