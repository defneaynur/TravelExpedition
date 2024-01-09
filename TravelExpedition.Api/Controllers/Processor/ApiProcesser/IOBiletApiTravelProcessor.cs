using RestSharp;
using TravelExpedition.Api.Models.Request.BusJourneysModels;
using TravelExpedition.Api.Models.Request.BusLocationsModels;
using TravelExpedition.Api.Models.Request.SessionModels;
using TravelExpedition.Api.Models.Response.BusJourneysModels;
using TravelExpedition.Api.Models.Response.BusLocationsModels;
using TravelExpedition.Api.Models.Response.SessionModels;

namespace TravelExpedition.Api.Controllers.Processor.ApiProcesser
{
    public interface IOBiletApiTravelProcessor
    {


        public Task<BusLocationsResponseModel> GetBusLocations(BusLocationsModel busLocationsModel);
        public Task<BusJourneysResponseModel> GetBusJourneys(BusJourneysModel busJourneysModel);
    }
}
