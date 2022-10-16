using Newtonsoft.Json;
using SecondHandCarBidProject.UserUI.GUI.ApiServices.Interface;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

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


        public async Task<TReturn> LoginAsync<TReturn, TData>(string loginUrl, TData postData)
        {
            var body = new StringContent(JsonConvert.SerializeObject(postData));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync(loginUrl, body);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }

            return default(TReturn);
        }


        public async Task<TReturn> PostAsync<TReturn, TData>(string urlSubDirectory, TData postData, string token)
        {
            var body = new StringContent(JsonConvert.SerializeObject(postData));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", token);

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
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", token);

            var response = await _client.PutAsync(urlSubDirectory, body);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }

            return default(TReturn);
        }

        public async Task<TReturn> GetByFilterAsync<TReturn>(string urlSubDirectory, string token, string filterQueryString = "")
        {
            if (!string.IsNullOrEmpty(filterQueryString))
                urlSubDirectory += "?" + filterQueryString;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", token);
            var response = await _client.GetAsync(urlSubDirectory);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }

            return default(TReturn);
        }

        public async Task<TReturn> DeleteByFilterAsync<TReturn>(string urlSubDirectory, string token, string filterQueryString)
        {
            if (!string.IsNullOrEmpty(filterQueryString))
                urlSubDirectory += "?" + filterQueryString;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", token);
            var response = await _client.DeleteAsync(urlSubDirectory);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());
            }
            return default(TReturn);
        }
    }
}

