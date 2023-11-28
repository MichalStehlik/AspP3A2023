using ASP04SessionServices.Helpers;

namespace ASP04SessionServices.Services
{
    public class SessionStorage<T> : ISessionStorage<T>
    {
        readonly ISession _session;

        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext!.Session;
        }

        public T LoadOrCreate(string key)
        {
            T? result = _session.Get<T>(key) ?? default;
            if (typeof(T).IsClass && result == null)
            {
                return (T)Activator.CreateInstance(typeof(T));
            }
            return result;
        }

        public void Save(string key, T data)
        {
            _session.Set(key, data);
        }
    }
}
