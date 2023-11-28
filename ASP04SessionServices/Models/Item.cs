namespace ASP04SessionServices.Models
{
    public class Item
    {
        public string Text { get; set; } = string.Empty;
        public int Amount { get; set; } = 1;
        public ItemState State { get; set; } = ItemState.Unresolved;
    }
}
