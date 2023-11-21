namespace ASP02DI.Services
{
    public interface ICounterService
    {
        int Value { get; set; }
        void Increment();
        void ReRoll();
    }
}
