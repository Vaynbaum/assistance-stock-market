using Newtonsoft.Json;

namespace coursework.Controllers.Download.DownloadedItem
{
    public class AssetDownloadedG
    {
        [JsonProperty("symbol")]
        public string Abbrevation { get; set; }

        [JsonProperty("name")]
        public string InstrumentName { get; set; }

        [JsonProperty("exchange")]
        public string MarketName { get; set; }

        [JsonProperty("type")]
        public string TypeName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
