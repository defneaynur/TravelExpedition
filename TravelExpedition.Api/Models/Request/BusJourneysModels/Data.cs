using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Request.BusJourneysModels
{
    public class Data
    {
        [JsonProperty("origin-id")]
        public int OriginId { get; set; }
        [JsonProperty("destination-id")]
        public int DestinationId { get; set; }
        [JsonProperty("departure-date")]
        public string DepartureDate { get; set; }
    }
}
