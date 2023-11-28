using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP03Session.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        //private readonly ISession _session;

        public string Data1 { get; set; }
        public string Data2 { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger/*, ISession session */)
        {
            _logger = logger;
            //_session = session;
        }

        public void OnGet()
        {
            Data1 = HttpContext.Session.GetString("dato2") ?? "none";
            //Data2 = _session.GetString("dato2") ?? "nothing";
        }
    }
}