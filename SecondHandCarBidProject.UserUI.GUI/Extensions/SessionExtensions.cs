
using Newtonsoft.Json;
using System.Web;


namespace SecondHandCarBidProject.UserUI.GUI.Extensions
{
    public static class SessionExtensions
    {
        public static void Set<T>(this HttpSessionStateBase session, string key, T value)
        {
            session.Add(key, value);
        }
        public static T Get<T>(this HttpSessionStateBase session, string key)
        {
            var value = session["key"].ToString();
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
}