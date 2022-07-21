using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coursework.Model;

namespace coursework.Factories
{
    public class MarketFactory
    {
        public Market Create(
            string abbreviation, string mic,
            string country, string timezone)
        {
            Market market = new Market
            {
                Abbreviation = abbreviation,
                MIC = mic,
                Country = country,
                Timezone = timezone,
            };
            return market;
        }
    }
}
