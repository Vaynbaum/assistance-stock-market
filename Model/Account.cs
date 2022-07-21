using coursework.Exceptions;
using coursework.Exeptions;
using System.Collections.Generic;

namespace coursework.Model
{
    public class Account
    {
        private List<Market> _markets;
        
        public string Password { get; set; }
        public string Login { get; set; }

        public Account()
        {
            _markets = new List<Market>();
        }

        public List<Market> Markets => _markets;
       
        public void AddMarket(Market market)
        {
            if (_markets.Contains(market))
                throw new AddMarketException("Биржа уже существует");
            _markets.Add(market);
        }

        public void DeleteMarket(Market market)
        {
            if (!_markets.Remove(market))
                throw new DeleteMarketException("Биржа не была удалена");
        }

        public void DeleteAsset(Asset asset, Market market)
        {
            if (Markets.IndexOf(market) < 0)
            {
                throw new DeleteAssetException("Биржа не была найдена");
            }
            else
            {
                market.DeleteAsset(asset);
            }
        }
    }
}
