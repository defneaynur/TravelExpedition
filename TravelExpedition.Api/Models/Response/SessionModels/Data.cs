using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Response.SessionModels
{
    public class Data
    {
        [JsonProperty("session-id")]
        public string SessionId { get; set; }
        [JsonProperty("device-id")]
        public string DeviceId { get; set; }
        [JsonProperty("affiliate")]
        public string Affiliate { get; set; }
        [JsonProperty("ddevice-type")]
        public string DeviceType { get; set; }
        [JsonProperty("device")]
        public string Device { get; set; }
        [JsonProperty("ip-country")]
        public string IpCountry { get; set; }
    }
}
