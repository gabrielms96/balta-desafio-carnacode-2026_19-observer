namespace DesignPatternChallengeObserver.Interface
{
    public interface IStockObserver
    {
        void UpdatePrice(string symbol, decimal price, decimal changePercent);
    }
}
