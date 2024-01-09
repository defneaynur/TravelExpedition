using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Response.BusJourneysModels
{
    public class Data
    {
        public int id { get; set; }

        [JsonProperty("partner-id")]
        public int partnerid { get; set; }

        [JsonProperty("partner-name")]
        public string partnername { get; set; }

        [JsonProperty("route-id")]
        public int routeid { get; set; }

        [JsonProperty("bus-type")]
        public string bustype { get; set; }

        [JsonProperty("total-seats")]
        public int totalseats { get; set; }

        [JsonProperty("available-seats")]
        public int availableseats { get; set; }
        public Journey journey { get; set; }
        public List<Feature> features { get; set; }

        [JsonProperty("origin-location")]
        public string originlocation { get; set; }

        [JsonProperty("destination-location")]
        public string destinationlocation { get; set; }

        [JsonProperty("is-active")]
        public bool isactive { get; set; }

        [JsonProperty("origin-location-id")]
        public int originlocationid { get; set; }

        [JsonProperty("destination-location-id")]
        public int destinationlocationid { get; set; }

        [JsonProperty("is-promoted")]
        public bool ispromoted { get; set; }

        [JsonProperty("cancellation-offset")]
        public int cancellationoffset { get; set; }

        [JsonProperty("has-bus-shuttle")]
        public bool hasbusshuttle { get; set; }

        [JsonProperty("disable-sales-without-gov-id")]
        public bool disablesaleswithoutgovid { get; set; }

        [JsonProperty("display-offset")]
        public object displayoffset { get; set; }

        [JsonProperty("partner-rating")]
        public double? partnerrating { get; set; }

    }
}
