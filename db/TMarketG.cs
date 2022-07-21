using coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework.db
{
    partial class TMarket
    {
        public TMarket(Market market)
        {
            Abbreviation = market.Abbreviation;
            Country = market.Country;
            MIC = market.MIC;
            Timezone = market.Timezone;
        }
        public bool CompareMarkets(Market market)
        {
            return (
                Abbreviation == market.Abbreviation &&
                Country == market.Country &&
                MIC == market.MIC &&
                Timezone == market.Timezone
                );
        }
    }
}
