using coursework.Exeptions;
using coursework.Fields;
using System.Collections.Generic;

namespace coursework.Model
{
    public class Session
    {
        public Session()
        {
            MarketFields = new List<Field>
            {
                new AbbreviationMarketField(),
                new MicMarketField(),
                new CountryMarketField(),
                new TimezoneMarketField(),
            };

            AssetFields = new List<Field>
            {
                new InstrumentAssetField(),
                new AbbreviationAssetField(),
                new TypeNameAssetField(),
                new CountryAssetField(),
                new CurrencyAssetField(),
            };
        }

        private Market _currentMarket;
        private Asset _currentAsset;
        public List<Asset> Assets
        {
            get
            {
                if (_currentMarket != null)
                    return _currentMarket.Assets;
                else
                    return new List<Asset>();
            }
        }
        public Market GetCurrentMarket()
        {
            return _currentMarket;
        }

        public List<Field> MarketFields { get; private set; }

        public List<Field> AssetFields { get; private set; }

        public void SetCurrentMarket(Market value)
        {
            _currentMarket = value;
            if (_currentMarket == null || Assets.Count > 0)
            {
                SetCurrentAsset(Assets[0]);
            }
            else
            {
                SetCurrentAsset(null);
            }
        }
        public Asset GetCurrentAsset()
        {
            return _currentAsset;
        }

        public void DeleteCurrentMarket()
        {
            _currentMarket = null;
            _currentAsset = null;
        }

        public void DeleteCurrentAsset()
        {
            _currentAsset = null;
        }

        public void SetCurrentAsset(Asset value)
        {
            if (_currentMarket.Assets.Contains(value) || value == null)
                _currentAsset = value;
            else
                throw new SetCurrentAssetException("Даного актива нет в текущей бирже");
        }
    }
}
