using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Response.BusJourneysModels
{
    public class Policy
    {
        [JsonProperty("max-seats")]
        public object maxseats { get; set; }

        [JsonProperty("max-single")]
        public object maxsingle { get; set; }

        [JsonProperty("max-single-males")]
        public object maxsinglemales { get; set; }

        [JsonProperty("max-single-females")]
        public object maxsinglefemales { get; set; }

        [JsonProperty("mixed-genders")]
        public bool mixedgenders { get; set; }

        [JsonProperty("gov-id")]
        public bool govid { get; set; }
        public bool lht { get; set; }
    }
}
