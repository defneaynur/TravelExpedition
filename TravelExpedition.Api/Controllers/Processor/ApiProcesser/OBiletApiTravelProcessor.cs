using TravelExpedition.Api.Controllers.Processor.Request;
using TravelExpedition.Api.Models.Request.BusJourneysModels;
using TravelExpedition.Api.Models.Request.BusLocationsModels;
using TravelExpedition.Api.Models.Response.BusJourneysModels;
using TravelExpedition.Api.Models.Response.BusLocationsModels;

namespace TravelExpedition.Api.Controllers.Processor.ApiProcesser;

/// <summary>
/// Represents a processor for interacting with OBilet API for travel-related operations.
/// </summary>
/// <remarks>
/// This class is responsible for handling API requests related to travel operations using the OBilet service.
/// </remarks>
/// <author>Aynur Gökgöz</author>
/// <email>aynur.gokgoz@gmail.com</email>
/// <created>08/01/2024</created>
public class OBiletApiTravelProcessor : IOBiletApiTravelProcessor
{
    private readonly IApiRequestProcessor _apiRequest;

    /// <summary>
    /// Initializes a new instance of the <see cref="OBiletApiTravelProcessor"/> class.
    /// </summary>
    /// <param name="apiRequest">The API request processor.</param>
    public OBiletApiTravelProcessor(IApiRequestProcessor apiRequest)
    {
        _apiRequest = apiRequest;
    }

    /// <summary>
    /// Gets bus journeys based on the provided <paramref name="busJourneysModel"/>.
    /// </summary>
    /// <param name="busJourneysModel">The model containing parameters for the bus journeys request.</param>
    /// <returns>A task representing the asynchronous operation. The result contains the response model for bus journeys.</returns>
    public async Task<BusJourneysResponseModel> GetBusJourneys(BusJourneysModel busJourneysModel)
    {
        return await _apiRequest.Execute<BusJourneysResponseModel>("/api/journey/getbusjourneys", busJourneysModel);
    }

    /// <summary>
    /// Gets bus locations based on the provided <paramref name="busLocationsModel"/>.
    /// </summary>
    /// <param name="busLocationsModel">The model containing parameters for the bus locations request.</param>
    /// <returns>A task representing the asynchronous operation. The result contains the response model for bus locations.</returns>
    public async Task<BusLocationsResponseModel> GetBusLocations(BusLocationsModel busLocationsModel)
    {
        return await _apiRequest.Execute<BusLocationsResponseModel>("/api/location/getbuslocations", busLocationsModel);
    }
}

