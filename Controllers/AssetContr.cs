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
    public class AssetContr
    {
        public event AttachedMessage<Asset> AssetAddedEvent;
        private AssetFactory _factory;
        private Market _market;
        private AddAssetForm _form;
        private FilterContr _filterController;
        private AssetManager manager;
        private List<object> allAssets;
        private AssetDownloadContr downloadContr { get; set; }

        public AssetContr()
        {
            
            downloadContr = new AssetDownloadContr();
            _factory = new AssetFactory();
        }

        public void AddAsset(Market market, List<Field> assetFields)
        {
            manager = new AssetManager(assetFields);
            _market = market;
            _form = new AddAssetForm();
            _form.AssetAdded += _form_AssetAdded;
            _form.NeedFilter += _form_NeedFilter;
            _form.Show();

            downloadContr.DownloadAssetsByAbbreviation(market.Abbreviation).
                ContinueWith(t => gettingAsset(t.Result));
        }

        public void DeleteAsset(Market market, Asset asset)
        {
            market.DeleteAsset(asset);
        }

        private void _form_AssetAdded(params object[] values)
        {
            Asset asset = values[0] as Asset;
            _market.AddAsset(asset.Clone());
            AssetAddedEvent?.Invoke(asset);
        }

        private void _form_NeedFilter()
        {
            _filterController = new FilterContr(manager, allAssets);
            FilterForm form = new FilterForm(_filterController, manager.Fields);
            form.NeedApplyFilteringEvent += Form_NeedApplyFilteringEvent1;
            form.Show();
        }

        private void Form_NeedApplyFilteringEvent1()
        {
            _filterController.ApplyFilter();
            _form.GetValueForShow(manager.Item, manager.Fields);
        }

        private void gettingAsset(DownloadedData<AssetDownloadedG> downloadedData)
        {
            allAssets = new List<object>();
            foreach (AssetDownloadedG assetDownloaded in downloadedData.Data)
            {
                Asset asset = _factory.Create(assetDownloaded.Abbrevation,
                    assetDownloaded.Country, assetDownloaded.Currency,
                    assetDownloaded.InstrumentName, assetDownloaded.TypeName);
                manager.AddItem(asset);
                allAssets.Add(asset);
            }
            _form.GetValueForShow(manager.Item, manager.Fields);
        }
    }
}
