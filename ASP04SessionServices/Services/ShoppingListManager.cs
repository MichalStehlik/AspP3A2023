using ASP04SessionServices.Models;

namespace ASP04SessionServices.Services
{
    public class ShoppingListManager : IShoppingListManager
    {
        private readonly SessionStorage<List<Item>> _ss;

        public ShoppingListManager(SessionStorage<List<Item>> ss)
        {
            _ss = ss;
        }

        public List<Item> Items { get; set; } = new List<Item>();
    }
}
