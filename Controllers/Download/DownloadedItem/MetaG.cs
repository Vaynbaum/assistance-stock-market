using Newtonsoft.Json;

namespace coursework.Controllers.Download.DownloadedItem
{
    public class MetaG
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
