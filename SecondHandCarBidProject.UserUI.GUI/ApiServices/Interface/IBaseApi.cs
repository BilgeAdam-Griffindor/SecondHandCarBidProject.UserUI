using SecondHandCarBidProject.UserUI.Dto.DTOs;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.GUI.ApiServices.Interface
{
    public interface IBaseApi
    {
        /// <summary>
        /// Should only be used for logging the user in to get an authorization token for other operations.
        /// </summary>
        /// <typeparam name="TReturn">Return type of the method. Should match what the API will return.</typeparam>
        /// <typeparam name="TData">Type of the data you want to send. Should match what the API requires.</typeparam>
        /// <param name="loginUrl">Subdirectory part of the full login url. Will be added to "apiBasePath" from settings.</param>
        /// <param name="postData">Login information. Will the added to the body of the request.</param>
        /// <returns>TReturn or Default of TReturn if the response was not successful.</returns>
        Task<ResponseModel<TReturn>> LoginAsync<TReturn, TData>(string loginUrl, TData postData);

        /// <summary>
        /// For post operations.
        /// </summary>
        /// <typeparam name="TReturn">Return type of the method. Should match what the API will return.</typeparam>
        /// <typeparam name="TData">Type of the data you want to send. Should match what the API requires.</typeparam>
        /// <param name="urlSubDirectory">Subdirectory part of the full action url you want to access. Will be added to "apiBasePath" from settings.</param>
        /// <param name="postData">Data you want to send to the API. Will be added to the body of the request.</param>
        /// <param name="token">Authorization token.</param>
        /// <returns>TReturn or Default of TReturn if the response was not successful.</returns>
        Task<TReturn> PostAsync<TReturn, TData>(string urlSubDirectory, TData postData, string token);

        /// <summary>
        /// For put operations.
        /// </summary>
        /// <typeparam name="TReturn">Return type of the method. Should match what the API will return.</typeparam>
        /// <typeparam name="TData">Type of the data you want to send. Should match what the API requires.</typeparam>
        /// <param name="urlSubDirectory">Subdirectory part of the full action url you want to access. Will be added to "apiBasePath" from settings.</param>
        /// <param name="putData">Data you want to send to the API. Will be added to the body of the request.</param>
        /// <param name="token">Authorization token.</param>
        /// <returns>TReturn or default of TReturn if the response was not successful.</returns>
        Task<TReturn> PutAsync<TReturn, TData>(string urlSubDirectory, TData putData, string token);

        /// <summary>
        /// For get operations. Can be used without a filter by leaving it empty.
        /// </summary>
        /// <typeparam name="TReturn">Return type of the method. Should match what the API will return.</typeparam>
        /// <param name="urlSubDirectory">Subdirectory part of the full action url you want to access. Will be added to "apiBasePath" from settings.</param>
        /// <param name="token">Authorization token.</param>
        /// <param name="filterQueryString">Query that will be used for filtering. Must be url safe. Variable names should match the ones in API.
        /// <para>Shouldn't begin with "?". Can take multiple values by separating variables with an "&amp;".</para> 
        /// <para>Example: "name=Dean&amp;age=25"</para> <para>List of values example: "ids=35&amp;ids=34"</para></param>
        /// <returns>TReturn or Default of TReturn if the response was not successful.</returns>
        Task<TReturn> GetByFilterAsync<TReturn>(string urlSubDirectory, string token, string filterQueryString = "");

        /// <summary>
        /// For delete operations.
        /// </summary>
        /// <typeparam name="TReturn">Return type of the method. Should match what the API will return.</typeparam>
        /// <param name="urlSubDirectory">Subdirectory part of the full action url you want to access. Will be added to "apiBasePath" from settings.</param>
        /// <param name="token">Authorization token.</param>
        /// <param name="filterQueryString">Query that will be used for filtering. Must be url safe. Variable names should match the ones in API.
        /// <para>Shouldn't begin with "?". Can take multiple values by separating variables with an "&amp;".</para> 
        /// <para>Example: "name=Dean&amp;age=25"</para> <para>List of values example: "ids=35&amp;ids=34"</para></param>
        /// <returns>TReturn or Default of TReturn if the response was not successful.</returns>
        Task<TReturn> DeleteByFilterAsync<TReturn>(string urlSubDirectory, string token, string filterQueryString);
    }
}
