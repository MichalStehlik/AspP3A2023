using ASP02DI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP02DI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICounterService _cs;

        public int Value { get; set; }
        public IndexModel(ILogger<IndexModel> logger, ICounterService cs)
        {
            _logger = logger;
            _cs = cs;
        }

        public void OnGet()
        {
            Value = _cs.Value;
        }

        public IActionResult OnGetRoll()
        {
            _cs.ReRoll();
            return RedirectToPage("/Index");
        }
        public IActionResult OnGetInc()
        {
            _cs.Increment();
            return RedirectToPage("/Index");
        }
    }
}