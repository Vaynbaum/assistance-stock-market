using coursework.Controllers.Download.DownloadControllers;
using coursework.Controllers.Download.DownloadedItem;
using coursework.Factories;
using coursework.Model;
using System;

namespace coursework.Controllers
{
    public class QuoteContr
    {
        private QouteFactory _factory;
        public event EmptyMessage QuotesGettedEvent;
        public event ErrorMessage NoGettedQoutes;
        private Asset _asset;
        private DownloadController<TimeSeries> quoteDownloadController { get; set; }
        public QuoteContr()
        {
            _factory = new QouteFactory();
            quoteDownloadController = new QuoteDownloadContr();
        }

        private void addedQutes(TimeSeries timeSeries)
        {
            if (timeSeries.Status != "ok")
            {
                NoGettedQoutes?.Invoke(timeSeries.Message);
            }
            else
            {
                _asset.ClearQuote();
                for (int i = timeSeries.Values.Count - 1; i >= 0; i--)
                {
                    ValueG value = timeSeries.Values[i];
                    Quote quote = _factory.
                        Create(value.Datetime, value.Open, value.High, value.Low, value.Close);
                    _asset.AddQuote(quote);
                }
                QuotesGettedEvent?.Invoke();
            }
        }

        public void AddQoutes(Asset asset, Market market, DateTime beginDate, DateTime endDate)
        {
            _asset = asset;

            quoteDownloadController.AllDownloadAsync(beginDate, endDate,
             asset.Abbreviation, market.Abbreviation, market.Timezone).
             ContinueWith(t => addedQutes(t.Result));
        }
    }
}
