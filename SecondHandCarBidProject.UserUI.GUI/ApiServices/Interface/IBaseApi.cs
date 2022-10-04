using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.GUI.ApiServices.Interface
{
    public interface IBaseApi
    {
        Task<TReturn> PostAsync<TReturn, TData>(string url, TData postData, string token);
        Task<TReturn> PutAsync<TReturn, TData>(string url, TData postData, string token);
        Task<TReturn> GetByIdAsync<TReturn>(string url, object id, string token);
        Task<TReturn> DeleteByIdAsync<TReturn>(string url, object id, string token);
    }
}
