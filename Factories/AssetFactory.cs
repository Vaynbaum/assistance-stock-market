using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coursework.Model;

namespace coursework.Factories
{
    public class AssetFactory
    {

        public Asset Create(string abbreviation, string country,
            string currency, string instrumentName, string type)
        {
            Asset asset = new Asset()
            {
                Type = type,
                Abbreviation = abbreviation,
                Country = country,
                Currency = currency,
                InstrumentName = instrumentName,
            };
            return asset;
        }
    }
}
