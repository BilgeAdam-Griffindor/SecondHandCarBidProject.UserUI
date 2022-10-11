using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SecondHandCarBidProject.UserUI.GUI.ApiServices.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace SecondHandCarBidProject.UserUI.GUI.ApiServices.Concrete
{
    public class BaseApi : IBaseApi
    {
        HttpClient _client;

        public BaseApi()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(ConfigurationManager.AppSettings["apiBasePath"]);
        }

        public async Task<TReturn> PostAsync<TReturn, TData>(string urlSubDirectory, TData postData, string token)
        {
            var body = new StringContent(JsonConvert.SerializeObject(postData));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _client.PostAsync(urlSubDirectory, body);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }

            return default(TReturn);
        }

        public async Task<TReturn> PutAsync<TReturn, TData>(string urlSubDirectory, TData putData, string token)
        {
            var body = new StringContent(JsonConvert.SerializeObject(putData));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _client.PutAsync(urlSubDirectory, body);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }

            return default(TReturn);
        }

        public async Task<TReturn> GetByIdAsync<TReturn>(string urlSubDirectory, object id, string token)
        {
            var response = await _client.GetAsync(urlSubDirectory + "?id=" + id);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }

            return default(TReturn);
        }

        //TODO Check new ways for querystring
        public async Task<TReturn> GetByFilterAsync<TReturn>(string urlSubDirectory, string token, string queryString = "", int page = 1, int perPage = 100)
        {
            string pageQueryString = "page=" + page + "&perPage=" + perPage;
            var fullQuery = queryString == "" ? pageQueryString : queryString + "&" + pageQueryString;

            var response = await _client.GetAsync(urlSubDirectory + "?" + fullQuery);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }

            return default(TReturn);
        }


        public async Task<TReturn> DeleteByIdAsync<TReturn>(string urlSubDirectory, object id, string token)
        {
            var response = await _client.DeleteAsync(urlSubDirectory + "?id=" + id);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }
            return default(TReturn);
        }
    }
}