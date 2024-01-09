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
    /// <summary>
    /// Controller for managing travel-related operations.
    /// </summary>
    public class TravelController : ControllerBase
    {
        private readonly IOBiletApiTravelProcessor _oBiletApiProcessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="TravelController"/> class.
        /// </summary>
        /// <param name="oBiletApiProcessor">The travel processor.</param>
        public TravelController(IOBiletApiTravelProcessor oBiletApiProcessor)
        {
            _oBiletApiProcessor = oBiletApiProcessor;
        }

        public IActionResult Index()
        {
            return Ok("TravelController Get method is called.");
        }

        /// <summary>
        /// Retrieves bus locations based on the provided bus locations model.
        /// </summary>
        /// <param name="BusLocationsModel">The bus locations model.</param>
        /// <returns>Returns a task representing the asynchronous operation with the bus locations response model.</returns>
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

        /// <summary>
        /// Retrieves bus journeys based on the provided bus journeys model.
        /// </summary>
        /// <param name="BusJourneysModel">The bus journeys model.</param>
        /// <returns>Returns a task representing the asynchronous operation with the bus journeys response model.</returns>
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
