using System.Collections.Generic;
using coursework.Exceptions;
using coursework.Exeptions;

namespace coursework.Model
{
    public class Market
    {

        public string Abbreviation { get; set; }

        public string Country { get; set; }

        public string MIC { get; set; }

        public string Timezone { get; set; }

        public List<Asset> Assets { get; private set; }

        public Market()
        {
            Assets = new List<Asset>();
        }

        public void AddAsset(Asset asset)
        {
            if (Assets.Contains(asset))
            {
                throw new AddQuoteException("Актив не был добавлен");
            }
            Assets.Add(asset);
        }

        public void DeleteAsset(Asset asset)
        {
            if (!Assets.Contains(asset))
            {
                throw new DeleteAssetException("Актив не был удален");
            }
            Assets.Remove(asset);
        }

        public Market Clone()
        {
            Market market = new Market()
            {
                Abbreviation = Abbreviation,
                Country = Country,
                MIC = MIC,
                Timezone = Timezone,
            };
            return market;
        }
    }
}
