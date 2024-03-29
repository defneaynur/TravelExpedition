﻿using Newtonsoft.Json;

namespace TravelExpedition.Api.Models.Response.SessionModels
{
    public class SessionResponseModel
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("data")]
        public Data Data { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("user-message")]
        public string UserMessage { get; set; }
        [JsonProperty("api-request-id")]
        public string ApiRequestId { get; set; }
        [JsonProperty("controller")]
        public string Controller { get; set; }
        [JsonProperty("client-request-id")]
        public string ClientRequestId { get; set; }
        [JsonProperty("web-correlation-id")]
        public string WebCorrelationId { get; set; }
        [JsonProperty("correlation-id")]
        public string CorrelationId { get; set; }
        [JsonProperty("parameters")]
        public string Parameters { get; set; }
    }
}
