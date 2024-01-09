using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Request.BaseModels
{
    public class BaseInfo
    {
        
        [JsonProperty("date")]
        public string? Date { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
    }
}
