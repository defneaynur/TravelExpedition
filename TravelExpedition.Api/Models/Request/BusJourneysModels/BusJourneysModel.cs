using Newtonsoft.Json;
using TravelExpedition.Api.Models.Request.BaseModels;

namespace TravelExpedition.Api.Models.Request.BusJourneysModels
{
    public class BusJourneysModel : BaseInfo
    {
        [JsonProperty("device-session")]
        public DeviceSession DeviceSession { get; set; }
        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
