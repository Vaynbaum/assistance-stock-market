using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace coursework.Controllers.Download.DownloadedItem
{
    public class MarketDownloadedG
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
