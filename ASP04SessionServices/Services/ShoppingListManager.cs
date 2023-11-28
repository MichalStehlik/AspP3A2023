using ASP04SessionServices.Models;

namespace ASP04SessionServices.Services
{
    public class ShoppingListManager : IShoppingListManager
    {
        private readonly SessionService _ss;

        public ShoppingListManager(SessionService ss)
        {
            _ss = ss;
        }

        public List<Item> Items { get; set; } = new List<Item>();
    }
}
