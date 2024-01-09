using TravelExpedition.Api.Controllers.Processor.Request;
using TravelExpedition.Api.Models.Request.SessionModels;
using TravelExpedition.Api.Models.Response.SessionModels;

namespace TravelExpedition.Api.Controllers.Processor.SessionProcessor;

/// <summary>
/// Handles the processing of OBilet API sessions.
/// </summary>
/// <remarks>
/// This class is responsible for managing and processing OBilet API sessions.
/// </remarks>
/// <author>Aynur Gökgöz</author>
/// <email>aynur.gokgoz@gmail.com</email>
/// <created>08/01/2024</created>
public class OBiletApiSessionProcessor : IOBiletApiSessionProcessor
{
    private readonly IApiRequestProcessor _apiRequest;

    /// <summary>
    /// Initializes a new instance of the <see cref="OBiletApiSessionProcessor"/> class.
    /// </summary>
    /// <param name="apiRequest">The API request processor.</param>
    public OBiletApiSessionProcessor(IApiRequestProcessor apiRequest)
    {
        _apiRequest = apiRequest;
    }

    /// <summary>
    /// Gets the session information from the OBilet API.
    /// </summary>
    /// <param name="sessionModel">The session model containing necessary information.</param>
    /// <returns>The response containing session details.</returns>
    public async Task<SessionResponseModel> GetSession(SessionModel sessionModel)
    {

        return await _apiRequest.Execute<SessionResponseModel>("/api/client/getsession", sessionModel);
    }
}

