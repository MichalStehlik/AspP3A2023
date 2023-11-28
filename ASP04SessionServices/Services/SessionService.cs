using ASP04SessionServices.Helpers;

namespace ASP04SessionServices.Services
{
    public class SessionService : ISessionService
    {
        private ISession _session;

        public SessionService(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
        }

        public void SaveSession<T>(string key, T value)
        {
            _session.Set(key, value);
        }

        public T GetSession<T>(string key)
        {
            T result = _session.Get<T>(key);
            return result;
        }
    }
}
