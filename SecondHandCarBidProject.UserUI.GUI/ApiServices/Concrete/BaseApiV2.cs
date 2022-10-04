using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using SecondHandCarBidProject.UserUI.GUI.ApiServices.Interface;

namespace SecondHandCarBidProject.UserUI.GUI.ApiServices.Concrete
{
    public class BaseApiV2 : IBaseApiV2
    {
        HttpClient _client;

        public BaseApiV2()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(ConfigurationManager.AppSettings["apiBasePath"]);
        }

        public async Task<BaseApiReturn> PostAsync<TData>(string urlSubDirectory, TData postData)
        {
            try
            {
                var body = new StringContent(JsonConvert.SerializeObject(postData));
                body.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await _client.PostAsync(urlSubDirectory, body);
                var content = await response.Content.ReadAsStringAsync();

                return new BaseApiReturn()
                {
                    StatusCode = (int)response.StatusCode,
                    ReasonPhrase = response.ReasonPhrase,
                    Content = content
                };
            }
            catch (Exception ex)
            {
                return new BaseApiReturn()
                {
                    StatusCode = -1,
                    ReasonPhrase = "",
                    Content = $@"{{""exceptionMessage"":""{ex.Message}"", ""innerExceptionMessage"": ""{ex.InnerException.Message}"" }}"
                };
            }
        }

        public async Task<BaseApiReturn> PutAsync<TData>(string urlSubDirectory, TData putData)
        {
            try
            {
                var body = new StringContent(JsonConvert.SerializeObject(putData));
                body.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await _client.PutAsync(urlSubDirectory, body);
                var content = await response.Content.ReadAsStringAsync();

                return new BaseApiReturn()
                {
                    StatusCode = (int)response.StatusCode,
                    ReasonPhrase = response.ReasonPhrase,
                    Content = content
                };
            }
            catch (Exception ex)
            {

                return new BaseApiReturn()
                {
                    StatusCode = -1,
                    ReasonPhrase = "",
                    Content = $@"{{""exceptionMessage"":""{ex.Message}"", ""innerExceptionMessage"": ""{ex.InnerException.Message}"" }}"
                };
            }
        }

        public async Task<BaseApiReturn> GetByIdAsync(string urlSubDirectory, object id)
        {
            try
            {
                var response = await _client.GetAsync(urlSubDirectory + "?id=" + id);
                var content = await response.Content.ReadAsStringAsync();

                return new BaseApiReturn()
                {
                    StatusCode = (int)response.StatusCode,
                    ReasonPhrase = response.ReasonPhrase,
                    Content = content
                };
            }
            catch (Exception ex)
            {

                return new BaseApiReturn()
                {
                    StatusCode = -1,
                    ReasonPhrase = "",
                    Content = $@"{{""exceptionMessage"":""{ex.Message}"", ""innerExceptionMessage"": ""{ex.InnerException.Message}"" }}"
                };
            }
        }

        public async Task<BaseApiReturn> DeleteByIdAsync(string urlSubDirectory, object id)
        {
            try
            {
                var response = await _client.DeleteAsync(urlSubDirectory + "?id=" + id);
                var content = await response.Content.ReadAsStringAsync();

                return new BaseApiReturn()
                {
                    StatusCode = (int)response.StatusCode,
                    ReasonPhrase = response.ReasonPhrase,
                    Content = content
                };
            }
            catch (Exception ex)
            {

                return new BaseApiReturn()
                {
                    StatusCode = -1,
                    ReasonPhrase = "",
                    Content = $@"{{""exceptionMessage"":""{ex.Message}"", ""innerExceptionMessage"": ""{ex.InnerException.Message}"" }}"
                };
            }
        }
    }
}