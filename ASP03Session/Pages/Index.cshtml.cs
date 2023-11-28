using ASP03Session.Helper;
using ASP03Session.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP03Session.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //private readonly ISession _session;

        public IndexModel(ILogger<IndexModel> logger/*, ISession session*/)
        {
            _logger = logger;
            //_session = session;
        }

        public void OnGet()
        {
            //_session.SetString("dato1", "ahoj");
            HttpContext.Session.SetString("dato2","nazdar");
            HttpContext.Session.Set<State>("myState", new State { Text = "AAA" }); ;
        }
    }
}