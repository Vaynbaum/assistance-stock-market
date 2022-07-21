using Newtonsoft.Json;
using System;

namespace coursework.Controllers.Download.DownloadedItem
{
    public class ValueG
    {
        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("open")]
        public float Open { get; set; }

        [JsonProperty("high")]
        public float High { get; set; }

        [JsonProperty("low")]
        public float Low { get; set; }

        [JsonProperty("close")]
        public float Close { get; set; }
    }
}
