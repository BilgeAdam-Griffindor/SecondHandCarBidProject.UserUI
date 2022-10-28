using Newtonsoft.Json;
using SecondHandCarBidProject.UserUI.Dto.DTOs;
using SecondHandCarBidProject.UserUI.GUI.ApiServices.Interface;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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


        public async Task<ResponseModel<TReturn>> LoginAsync<TReturn, TData>(string loginUrl, TData postData)
        {
            var body = new StringContent(JsonConvert.SerializeObject(postData));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var content = new StringContent(JsonConvert.SerializeObject(postData), Encoding.UTF8, "application/json");
            var response = _client.PostAsync(loginUrl, content).Result;

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseModel<TReturn>>(await response.Content.ReadAsStringAsync());
            }

            return default(ResponseModel<TReturn>);
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

        public async Task<ResponseModel<TReturn>> GetAddressRegisterAsync<TReturn>(string loginUrl)
        {
            var response = await _client.GetAsync(loginUrl);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseModel<TReturn>>(await response.Content.ReadAsStringAsync());
            }

            return default(ResponseModel<TReturn>);
        }

        public async Task<ResponseModel<TReturn>> RegisterAsync<TReturn, TData>(string loginUrl, TData postData)
        {
            var body = new StringContent(JsonConvert.SerializeObject(postData));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var content = new StringContent(JsonConvert.SerializeObject(postData), Encoding.UTF8, "application/json");
            var response = _client.PostAsync(loginUrl, content).Result;

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ResponseModel<TReturn>>(await response.Content.ReadAsStringAsync());
            }

            return default(ResponseModel<TReturn>);
        }
    }
}

