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
        public async Task<TReturn> LoginAsync<TReturn, TData>(TData postData)
        {
            var response = await baseApi.LoginAsync<TReturn, TData>(postData);
            return response;
        }
        public async Task<TReturn> PostAsync<TReturn, TData>(string urlSubDirectory, TData postData, string token)
        {
            var response = await baseApi.PostAsync<TReturn, TData>(urlSubDirectory, postData, token);

            return response;
        }
        public async Task<TReturn> PutAsync<TReturn, TData>(string urlSubDirectory, TData putData, string token)
        {
         var response = await baseApi.PutAsync<TReturn, TData>(urlSubDirectory, putData, token);
            return response;
        }


        //TODO Check new ways for querystring
        public async Task<TReturn> GetByFilterAsync<TReturn>(string urlSubDirectory, string token, string queryString = "", int page = 1, int perPage = 100)
        {
            var response = await baseApi.GetByFilterAsync<TReturn>(urlSubDirectory, token, queryString, page, perPage);
            return response;
        }

        public async Task<TReturn> GetByIdAsync<TReturn>(string urlSubDirectory, object id, string token)
        {
            var response = await baseApi.GetByIdAsync<TReturn>(urlSubDirectory, id, token);
            return response;
        }


        public async Task<TReturn> DeleteByIdAsync<TReturn>(string urlSubDirectory, object id, string token)
        {
            var response = await baseApi.DeleteByIdAsync<TReturn>(urlSubDirectory, id, token);
            return response;
        }
    }
}
