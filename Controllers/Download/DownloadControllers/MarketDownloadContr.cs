using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using coursework.Controllers.Download.DownloadedItem;
using Newtonsoft.Json;

namespace coursework.Controllers.Download.DownloadControllers
{
    public class MarketDownloadContr : DownloadController<DownloadedData<MarketDownloadedG>>
    {
        public async override Task<DownloadedData<MarketDownloadedG>> AllDownloadAsync(params object[] values)
        {
            WebClient webClient = new WebClient();
            string json = "";
            await Task.Run(() =>
            {
                json = webClient.DownloadString(Properties.Resources.URLForDownloadMarkets);
            });
            DownloadedData<MarketDownloadedG> markets = JsonConvert.DeserializeObject<DownloadedData<MarketDownloadedG>>(json);
            return markets;
        }
    }
}
