using SecondHandCarBidProject.UserUI.GUI.ApiServices.Concrete;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.GUI.ApiServices.Interface
{
    public interface IBaseApiV2
    {
        Task<BaseApiReturn> PostAsync<TData>(string url, TData postData);
        Task<BaseApiReturn> PutAsync<TData>(string url, TData postData);
        Task<BaseApiReturn> GetByIdAsync(string url, object id);
        Task<BaseApiReturn> DeleteByIdAsync(string url, object id);
    }
}
