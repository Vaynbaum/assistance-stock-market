using Newtonsoft.Json;
using System.Collections.Generic;

namespace coursework.Controllers.Download.DownloadedItem
{
    public class TimeSeries
    {
        [JsonProperty("meta")]
        public MetaG Meta { get; set; }

        [JsonProperty("values")]
        public List<ValueG> Values { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
