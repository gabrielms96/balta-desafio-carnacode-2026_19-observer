using DesignPatternChallengeObserver.Interface;

namespace DesignPatternChallengeObserver.ConcreteObserver
{
    public class MobileApp : IStockObserver
    {
        public string UserId { get; set; }

        public MobileApp(string userId)
        {
            UserId = userId;
        }

        public void UpdatePrice(string symbol, decimal price, decimal changePercent) =>
            Console.WriteLine($"  → [App Mobile {UserId}] 📱 Push: {symbol} agora em R$ {price:N2} ({changePercent:+0.00;-0.00}%)");

    }
}
