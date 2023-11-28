using ASP03Session.Helper;
using ASP03Session.Models;
using ASP03Session.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP03Session.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //private readonly ISession _session;
        private readonly IStateManager _state;

        public IndexModel(ILogger<IndexModel> logger, IStateManager state)
        {
            _logger = logger;
            _state = state;
        }

        public void OnGet()
        {
            //_session.SetString("dato1", "ahoj");
            HttpContext.Session.SetString("dato2","nazdar");
            HttpContext.Session.Set<State>("myState", new State { Text = "AAA" });
            _state.Write(new State { Text = "BBB"});
        }
    }
}