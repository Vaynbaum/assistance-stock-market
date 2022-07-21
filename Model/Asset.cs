using System.Collections.Generic;

namespace coursework.Model
{
    public class Asset
    {
        public string Abbreviation { get; set; }

        public string Type { get; set; }

        public string InstrumentName { get; set; }

        public string Country { get; set; }

        public string Currency { get; set; }

        public List<Quote> Quotes { get; private set; }

        public Asset()
        {
            Quotes = new List<Quote>();
        }

        public void AddQuote(Quote quote)
        {
            Quotes.Add(quote);
        }

        public void ClearQuote()
        {
            Quotes.Clear();
        }

        public Asset Clone()
        {
            Asset asset = new Asset()
            {
                Type = Type,
                Abbreviation = Abbreviation,
                Country = Country,
                Currency = Currency,
                InstrumentName = InstrumentName,
            };

            return asset;
        }
    }
}
