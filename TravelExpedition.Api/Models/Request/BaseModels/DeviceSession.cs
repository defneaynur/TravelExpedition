using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Request.BaseModels
{
    public class DeviceSession
    {
        [JsonProperty("session-id")]
        public string SessionId { get; set; }
        [JsonProperty("device-id")]
        public string DeviceId { get; set; }
    }
}
