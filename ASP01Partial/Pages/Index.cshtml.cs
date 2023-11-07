using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP01Partial.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string LastAccess { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            LastAccess = Request.Cookies["last-access"] ?? DateTime.Now.ToString();
            var options = new CookieOptions {
                Expires = DateTime.Now.AddDays(365),
                Secure = false,
                HttpOnly = false
            };
            Response.Cookies.Append("last-access", 
                DateTime.Now.ToString(), 
                options);
        }
    }
}