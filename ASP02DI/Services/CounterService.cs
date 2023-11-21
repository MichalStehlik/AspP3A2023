namespace ASP02DI.Services
{
    public class CounterService: ICounterService
    {
        public CounterService()
        {
            Value = Random.Shared.Next(0, 100);
        }

        public int Value { get; set; } = 42;
        public void ReRoll()
        {
            Value = Random.Shared.Next(0, 100);
        }

        public void Increment()
        {
            Value++;
        }
    }
}
