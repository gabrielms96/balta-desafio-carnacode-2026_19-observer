using DesignPatternChallengeObserver.Interface;

namespace DesignPatternChallengeObserver.ConcreteObserver
{
    public class Investor : IStockObserver
    {
        public string Name { get; set; }
        public decimal AlertThreshold { get; set; }

        public Investor(string name, decimal alertThreshold)
        {
            Name = name;
            AlertThreshold = alertThreshold;
        }

        public void UpdatePrice(string symbol, decimal price, decimal changePercent)
        {
            Console.WriteLine($"  → [Investidor {Name}] Notificado sobre {symbol}");

            if (Math.Abs(changePercent) >= AlertThreshold)
            {
                Console.WriteLine($"  → [Investidor {Name}] ⚠️ ALERTA! Mudança de {changePercent:+0.00;-0.00}% excedeu limite de {AlertThreshold}%");
            }
        }
    }
}
