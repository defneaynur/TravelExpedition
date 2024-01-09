using Newtonsoft.Json;
using TravelExpedition.Api.Models.Response.BusJourneysModels;

namespace TravelExpedition.Api.Models.Response.BusLocationsModels
{
    public class BusLocationsResponseModel
    {
        public string status { get; set; }
        public List<Data> data { get; set; }
        public object message { get; set; }

        [JsonProperty("user-message")]
        public object usermessage { get; set; }

        [JsonProperty("api-request-id")]
        public object apirequestid { get; set; }
        public string controller { get; set; }
    }
}
