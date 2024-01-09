using Core.Framework.Response;
using Microsoft.AspNetCore.Mvc;
using TravelExpedition.Api.Controllers.Processor.ApiProcesser;
using TravelExpedition.Api.Models.Request.BusJourneysModels;
using TravelExpedition.Api.Models.Request.BusLocationsModels;
using TravelExpedition.Api.Models.Request.SessionModels;
using TravelExpedition.Api.Models.Response.BusJourneysModels;
using TravelExpedition.Api.Models.Response.BusLocationsModels;
using TravelExpedition.Api.Models.Response.SessionModels;


namespace TravelExpedition.Api.Controllers
{
    //[Route("api/Travel")]
    //[ApiController]
    public class TravelController : ControllerBase
    {

        private readonly IOBiletApiTravelProcessor _oBiletApiProcessor;

        public TravelController(IOBiletApiTravelProcessor oBiletApiProcessor)
        {
            _oBiletApiProcessor = oBiletApiProcessor;
        }

        public IActionResult Index()
        {
            return Ok("TravelController Get method is called.");
        }

        [HttpPost]
        public async Task<CoreResponse<BusLocationsResponseModel>> GetBusLocations([FromBody] BusLocationsModel BusLocationsModel)
        {
            var response = _oBiletApiProcessor.GetBusLocations(BusLocationsModel);
            return new CoreResponse<BusLocationsResponseModel>
            {
                ResponseCode = CoreResponseCode.Success,
                Data = response.Result,
            };
        }

        [HttpPost]
        public async Task<CoreResponse<BusJourneysResponseModel>> GetBusJourneys([FromBody] BusJourneysModel BusJourneysModel)
        {
            var response = _oBiletApiProcessor.GetBusJourneys(BusJourneysModel);

            return new CoreResponse<BusJourneysResponseModel>
            {
                ResponseCode = CoreResponseCode.Success,
                Data = response.Result,
            };
        }

    }
}
