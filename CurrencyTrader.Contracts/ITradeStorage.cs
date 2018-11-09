using System.Collections.Generic;

namespace CurrencyTrader.Contracts
{
    public interface ITradeStorage
    {
        void Persist(IEnumerable<TradeRecord> trades);
        //added to pass the logger from Ado to SyncTradeStorage
        ILogger GetLogger();
    }
}