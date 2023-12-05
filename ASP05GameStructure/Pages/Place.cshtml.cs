using ASP05GameStructure.Models;
using ASP05GameStructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP05GameStructure.Pages
{
    public class PlaceModel : PageModel
    {
        private readonly LocationService _locationService;
        public Location? Location { get; set; }
        public List<Connection> Connections { get; set; }

        public PlaceModel(LocationService locationService)
        {
            _locationService = locationService;
        }

        public ActionResult OnGet(int id)
        {
            Location = _locationService.GetLocation(id);
            if (Location == null)
            {
                return NotFound();
            }
            Connections = _locationService.GetConnections(id);
            return Page();
        }
    }
}
