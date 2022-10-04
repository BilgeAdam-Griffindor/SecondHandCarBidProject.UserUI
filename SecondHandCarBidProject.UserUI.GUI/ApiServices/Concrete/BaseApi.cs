using Newtonsoft.Json;
using SecondHandCarBidProject.UserUI.GUI.ApiServices.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

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

        public async Task<TReturn> PostAsync<TReturn, TData>(string urlSubDirectory, TData postData)
        {
            var body = new StringContent(JsonConvert.SerializeObject(postData));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync(urlSubDirectory, body);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }

            return default(TReturn);
        }

        public async Task<TReturn> PutAsync<TReturn, TData>(string urlSubDirectory, TData putData)
        {
            var body = new StringContent(JsonConvert.SerializeObject(putData));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PutAsync(urlSubDirectory, body);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }

            return default(TReturn);
        }

        public async Task<TReturn> GetByIdAsync<TReturn>(string urlSubDirectory, object id)
        {
            var response = await _client.GetAsync(urlSubDirectory+"?id=" + id);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }

            return default(TReturn);
        }

        public async Task<TReturn> DeleteByIdAsync<TReturn>(string urlSubDirectory, object id)
        {
            var response = await _client.DeleteAsync(urlSubDirectory+"?id=" + id);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }
            return default(TReturn);
        }
    }
}