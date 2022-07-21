using Newtonsoft.Json;
using System.Collections.Generic;

namespace coursework.Controllers.Download.DownloadedItem
{
    public class DownloadedData<T>
    {
        [JsonProperty("data")]
        public List<T> Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
