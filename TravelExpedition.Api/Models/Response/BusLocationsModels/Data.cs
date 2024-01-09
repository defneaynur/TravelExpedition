using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Response.BusLocationsModels
{
    public class Data
    {
        public int id { get; set; }

        [JsonProperty("parent-id")]
        public int parentid { get; set; }
        public string type { get; set; }
        public string name { get; set; }

        [JsonProperty("geo-location")]
        public GeoLocation geolocation { get; set; }

        [JsonProperty("tz-code")]
        public string tzcode { get; set; }

        [JsonProperty("weather-code")]
        public object weathercode { get; set; }
        public int rank { get; set; }

        [JsonProperty("reference-code")]
        public object referencecode { get; set; }
        public string keywords { get; set; }

    }
}
