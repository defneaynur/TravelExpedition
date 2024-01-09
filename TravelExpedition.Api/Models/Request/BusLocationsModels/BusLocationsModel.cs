using Newtonsoft.Json;
using TravelExpedition.Api.Models.Request.BaseModels;

namespace TravelExpedition.Api.Models.Request.BusLocationsModels
{
    public class BusLocationsModel : BaseInfo
    {
        [JsonProperty("data")]
        public string? Data { get; set; }
        [JsonProperty("device-session")]
        public DeviceSession DeviceSession { get; set; }

    }
}
