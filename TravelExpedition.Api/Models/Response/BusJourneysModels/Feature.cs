using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Response.BusJourneysModels
{
    public class Feature
    {
        public int id { get; set; }
        public byte? priority { get; set; }
        public string name { get; set; }
        public object description { get; set; }

        [JsonProperty("is-promoted")]
        public bool ispromoted { get; set; }

        [JsonProperty("back-color")]
        public object backcolor { get; set; }

        [JsonProperty("fore-color")]
        public object forecolor { get; set; }
    }
}
