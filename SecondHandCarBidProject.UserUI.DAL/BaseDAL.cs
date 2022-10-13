using SecondHandCarBidProject.UserUI.GUI.ApiServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.DAL
{
    public class BaseDAL
    {
        BaseApi baseApi;
        public BaseDAL(BaseApi _baseApi)
        {
            baseApi = _baseApi;
        }
        public async Task<TReturn> LoginAsync<TReturn, TData>(string loginUrl, TData postData)
        {
            var response = await baseApi.LoginAsync<TReturn, TData>(loginUrl, postData);
            return response;
        }


        public async Task<TReturn> PostAsync<TReturn, TData>(string urlSubDirectory, TData postData, string token)
        {
            var response = await baseApi.PostAsync<TReturn, TData>(urlSubDirectory, postData, token);
            return response;
        }


        public async Task<TReturn> PutAsync<TReturn, TData>(string urlSubDirectory, TData putData, string token)
        {
            var response = await baseApi.PutAsync<TReturn, TData>(urlSubDirectory, putData, token) ;
            return response;
        }

        public async Task<TReturn> GetByFilterAsync<TReturn>(string urlSubDirectory, string token, string filterQueryString = "")
        {
            var response = await baseApi.GetByFilterAsync<TReturn>(urlSubDirectory, token, filterQueryString);
            return response;
        }

        public async Task<TReturn> DeleteByFilterAsync<TReturn>(string urlSubDirectory, string token, string filterQueryString)
        {
            var response = await baseApi.DeleteByFilterAsync<TReturn>(urlSubDirectory, token, filterQueryString);
            return response;
        }
       
    }
}
