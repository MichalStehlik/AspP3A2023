using ASP02DI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP02DI.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly ICounterService _cs;

        public int Value { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger, ICounterService cs)
        {
            _logger = logger;
            _cs = cs;
        }

        public void OnGet()
        {
            Value = _cs.Value;
        }
    }
}