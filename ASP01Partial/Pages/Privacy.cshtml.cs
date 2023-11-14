using ASP01Partial.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP01Partial.Helpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ASP01Partial.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnGetMessage(string txt)
        {
            TempData.AddMessage("msg1", new TempMessage(MessageType.Success, "We did it!"));
            TempData.AddMessage("msg2", new TempMessage(MessageType.Danger,  txt));
            return RedirectToPage();
        }
    }
}