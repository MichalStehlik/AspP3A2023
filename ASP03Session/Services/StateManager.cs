using ASP03Session.Models;
using ASP03Session.Helper;

namespace ASP03Session.Services
{
    public class StateManager : IStateManager
    {
        private const string SESSION_KEY = "StateData";
        private readonly IHttpContextAccessor _hca;

        public StateManager(IHttpContextAccessor hca)
        {
            _hca = hca;
        }

        public State Read()
        {
            return _hca.HttpContext!.Session.Get<State>(SESSION_KEY) ?? new State();
        }

        public void Write(State s)
        {
            _hca.HttpContext!.Session.Set<State>(SESSION_KEY, s);
        }
    }
}
