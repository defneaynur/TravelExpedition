using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Response.BusJourneysModels
{
    public class BusJourneysResponseModel
    {
        public string status { get; set; }
        public List<Data> data { get; set; }
        public object message { get; set; }

        [JsonProperty("user-message")]
        public string usermessage { get; set; }

        [JsonProperty("api-request-id")]
        public object apirequestid { get; set; }
        public string controller { get; set; }
    }
}
