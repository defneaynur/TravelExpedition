using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Response.BusJourneysModels
{

        public class Journey
        {
        public string kind { get; set; }
        public string code { get; set; }
        public List<Stop> stops { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime departure { get; set; }
        public DateTime arrival { get; set; }
        public string currency { get; set; }
        public string duration { get; set; }

        [JsonProperty("original-price")]
        public double originalprice { get; set; }

        [JsonProperty("internet-price")]
        public double internetprice { get; set; }
        public object booking { get; set; }

        [JsonProperty("bus-name")]
        public string busname { get; set; }
        public Policy policy { get; set; }
        public List<string> features { get; set; }
        public object description { get; set; }
        public object available { get; set; }
    }
    
}
