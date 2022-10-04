using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.GUI.ApiServices.Interface
{
    public interface IBaseApi
    {
        Task<TReturn> PostAsync<TReturn, TData>(string url, TData postData);
        Task<TReturn> PutAsync<TReturn, TData>(string url, TData postData);
        Task<TReturn> GetByIdAsync<TReturn>(string url, object id);
        Task<TReturn> DeleteByIdAsync<TReturn>(string url, object id);
    }
}
