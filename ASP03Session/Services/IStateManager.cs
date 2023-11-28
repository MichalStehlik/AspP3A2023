using ASP03Session.Models;

namespace ASP03Session.Services
{
    public interface IStateManager
    {
        State Read();
        void Write(State s);
    }
}
