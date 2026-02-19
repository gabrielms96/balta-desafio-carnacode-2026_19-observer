using DesignPatternChallengeObserver.Interface;

namespace DesignPatternChallengeObserver.ConcreteSubject
{
    public class Stock
    {
        public string Symbol { get; set; }
        decimal changePercent { get; set; }
        public decimal Price { get; private set; }
        public DateTime LastUpdate { get; private set; }

        public Stock(string symbol, decimal initialPrice)
        {
            Symbol = symbol;
            Price = initialPrice;
            LastUpdate = DateTime.Now;
            changePercent = 0;
        }

        private readonly List<IStockObserver> _observers = new();

        public void AddObserver(List<IStockObserver> observer) => _observers.AddRange(observer);

        public void UpdatePrice(decimal newPrice)
        {
            if (Price != newPrice)
            {
                decimal oldPrice = Price;
                Price = newPrice;
                LastUpdate = DateTime.Now;

                changePercent = ((newPrice - oldPrice) / oldPrice) * 100;

                Console.WriteLine($"\n[{Symbol}] Preço atualizado: R$ {oldPrice:N2} → R$ {newPrice:N2} ({changePercent:+0.00;-0.00}%)");
                Notify();
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.UpdatePrice(Symbol, Price, changePercent);
            }
        }
    }
}
