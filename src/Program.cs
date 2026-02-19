using DesignPatternChallengeObserver.ConcreteObserver;
using DesignPatternChallengeObserver.ConcreteSubject;
using DesignPatternChallengeObserver.Interface;

namespace DesignPatternChallengeObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Monitoramento de Ações ===");


            var petr4 = new Stock("PETR4", 35.50m);
            // Problema: Precisa registrar cada observador individualmente

            petr4.AddObserver(new List<IStockObserver>
            {
                new Investor("João Silva", 3.0m),
                new Investor("Maria Santos", 5.0m),
                new MobileApp("user123"),
                new TradingBot("AlgoTrader", 2.0m, 2.5m),
            });

            // Simulando mudanças de preço
            Console.WriteLine("\n=== Movimentações do Mercado ===");

            petr4.UpdatePrice(36.20m); // +1.97%
            Thread.Sleep(500);

            petr4.UpdatePrice(37.50m); // +3.59%
            Thread.Sleep(500);

            petr4.UpdatePrice(35.00m); // -6.67%
            Thread.Sleep(500);
        }
    }
}