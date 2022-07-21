using coursework.Controllers.Download.DownloadedItem;
using coursework.Model;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace coursework.Controllers.Download.DownloadControllers
{
    public class QuoteDownloadContr : DownloadController<TimeSeries>
    {
        public async override Task<TimeSeries> AllDownloadAsync(params object[] values)
        {
            WebClient webClient = new WebClient();
            KeyToAPI key = KeyToAPI.Key();
            string json = "";
            await Task.Run(() =>
            {
                json = webClient.DownloadString(
                string.Format(Properties.Resources.URLForDownloadQuotes,
                values[2], values[3], values[4],
                Convert.ToDateTime(values[0]).Date.ToString("yyyy-MM-dd"),
                Convert.ToDateTime(values[1]).Date.ToString("yyyy-MM-dd"),
                key.KeyApi));
            });
            TimeSeries series = JsonConvert.DeserializeObject<TimeSeries>(json);
            return series;
        }
    }
}
