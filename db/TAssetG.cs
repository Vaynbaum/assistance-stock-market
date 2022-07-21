using coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.db
{
    partial class TAsset
    {
        public TAsset()
        {

        }

        public TAsset(Asset asset)
        {
            Abbreviation = asset.Abbreviation;
            Type = asset.Type;
            InstrumentName = asset.InstrumentName;
            Country = asset.Country;
            Currency = asset.Currency;
        }

        public bool CompareAssets(Asset asset)
        {
            return (
                Type == asset.Type &&
                InstrumentName == asset.InstrumentName && 
                Country == asset.Country &&
                Currency == asset.Currency &&
                Abbreviation == asset.Abbreviation
            );
        }
    }
}
