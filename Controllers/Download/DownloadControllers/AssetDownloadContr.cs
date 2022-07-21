using coursework.Controllers.Download.DownloadedItem;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace coursework.Controllers.Download.DownloadControllers
{
    public class AssetDownloadContr
    {
        public async Task<DownloadedData<AssetDownloadedG>> DownloadAssetsByAbbreviation(string acronym)
        {
            WebClient webClient = new WebClient();
            string json = "";
            await Task.Run(() =>
            {
                json = webClient.DownloadString(string.Format(Properties.Resources.URLForDownloadAssetsByMarket, acronym));
            });
            DownloadedData<AssetDownloadedG> assets = JsonConvert.DeserializeObject<DownloadedData<AssetDownloadedG>>(json);
            return assets;
        }
    }
}
