using Newtonsoft.Json;

namespace eshop.MVC.Extensions
{
    public static class SessionExtensions
    {
        public static T GetJson<T>(this ISession session, string key) where T : class, new()
        {

            return session.GetString(key) == null ? new T() :
                                                    JsonConvert.DeserializeObject<T>(session.GetString(key));
        }
    }
}
