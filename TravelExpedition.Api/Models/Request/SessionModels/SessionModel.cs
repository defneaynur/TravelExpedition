using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Request.SessionModels
{
    public class SessionModel
    {
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("connection")]
        public Connection Connection { get; set; }
        [JsonProperty("browser")]
        public Browser Browser { get; set; }
        [JsonProperty("application")]
        public Application Application { get; set; }
    }
}
