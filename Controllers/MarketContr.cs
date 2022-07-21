using coursework.Controllers.Download.DownloadControllers;
using coursework.Controllers.Download.DownloadedItem;
using coursework.Controllers.Filter;
using coursework.Controllers.Managers;
using coursework.Factories;
using coursework.Fields;
using coursework.Forms;
using coursework.Model;
using System.Collections.Generic;

namespace coursework.Controllers
{
    public class MarketContr
    {
        public event AttachedMessage<Market> MarketAddedEvent;
        private Account _account;
        private MarketDownloadContr _downloadController;
        private MarketFactory _factory;
        private Manager _marketManager;
        private FilterContr _filterContr;
        AddMarketForm _form;

        public List<object> AllMarkets { get; private set; }

        public MarketContr()
        {
            _downloadController = new MarketDownloadContr();
            _factory = new MarketFactory();
            AllMarkets = new List<object>();
        }

        public void AddMarket(Account account, List<Field> marketFields)
        {
            _marketManager = new MarketManager(marketFields);
            _account = account;
            _form = new AddMarketForm(_marketManager.Fields, AllMarkets);
            _form.NeedToFilter += _form_NeedToFilter;
            _form.MarketAdded += _form_MarketAdded;
            _form.Show();
        }

        public void DeleteMarket(Account account, Market market)
        {
            account.DeleteMarket(market);
        }

        private void _form_MarketAdded(params object[] values)
        {
            _account.AddMarket(values[0] as Market);
            MarketAddedEvent?.Invoke(values[0] as Market);
        }

        private void _form_NeedToFilter()
        {
            _filterContr = new FilterContr(_marketManager, AllMarkets);
            FilterForm form = new FilterForm(_filterContr, _marketManager.Fields);
            form.NeedApplyFilteringEvent += Form_NeedApplyFilteringEvent;
            form.Show();
        }

        private void Form_NeedApplyFilteringEvent()
        {
            _filterContr.ApplyFilter();
            _form.DisplayMarket(_marketManager.Fields, _marketManager.Item);
        }

        public void AddMarket(params string[] values)
        {
            Market market = _factory.Create(values[0], values[1],
                values[2], values[3]);
            _account.AddMarket(market);
        }

        private void addAllMarket(DownloadedData<MarketDownloadedG> downloadedData)
        {
            AllMarkets.Clear();
            foreach (MarketDownloadedG marketDownloaded in downloadedData.Data)
            {
                Market market = _factory.Create(
                    marketDownloaded.Name, marketDownloaded.Code,
                     marketDownloaded.Country, marketDownloaded.Timezone);
                AllMarkets.Add(market);
            }
        }

        public void GetAllMarkets()
        {
            _downloadController.AllDownloadAsync().ContinueWith(t => addAllMarket(t.Result));
        }
    }
}
