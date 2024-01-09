using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Request.SessionModels
{
    public class Application
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("equipment-id")]
        public string EquipmentId { get; set; }

    }
}
