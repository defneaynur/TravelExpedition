using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Request.SessionModels
{
    public class Connection
    {
        [JsonProperty("ip-address")]
        public string IpAddress { get; set; }
        [JsonProperty("port")]
        public string Port { get; set; }
    }
}
