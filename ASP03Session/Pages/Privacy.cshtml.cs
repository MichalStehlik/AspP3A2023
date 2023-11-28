using ASP03Session.Helper;
using ASP03Session.Models;
using ASP03Session.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP03Session.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IStateManager _state;

        public PrivacyModel(ILogger<PrivacyModel> logger, IStateManager state)
        {
            _logger = logger;
            _state = state;
        }

        //private readonly ISession _session;

        public string Data1 { get; set; }
        public string Data2 { get; set; }

        public State State { get; set; }


        public void OnGet()
        {
            Data1 = HttpContext.Session.GetString("dato2") ?? "none";
            //Data2 = _session.GetString("dato2") ?? "nothing";
            Data2 = HttpContext.Session.Get<State>("myState")!.Text ?? "nil";
            State = _state.Read();
        }
    }
}