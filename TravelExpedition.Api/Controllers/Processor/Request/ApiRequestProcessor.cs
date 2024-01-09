using Core.Config.Injection;
using Newtonsoft.Json;
using RestSharp;
using TravelExpedition.Api.ServiceClient;

namespace TravelExpedition.Api.Controllers.Processor.Request;

/// <summary>
/// Represents a class for processing API requests.
/// </summary>
/// <remarks>
/// This class provides methods to send HTTP requests to an API endpoint and handle the responses.
/// It encapsulates the logic for making API calls and handling the authentication details.
/// </remarks>
/// <author>Aynur Gökgöz</author>
/// <email>aynur.gokgoz@gmail.com</email>
/// <created>08/01/2024</created>
public class ApiRequestProcessor : IApiRequestProcessor
{
    private readonly IOBiletV2ServiceClient _oBiletV2Service;
    private readonly IBaseInjection _baseInjection;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiRequestProcessor"/> class with the specified dependencies.
    /// </summary>
    /// <param name="oBiletV2Service">The service client for OBiletV2.</param>
    /// <param name="baseInjection">The base injection.</param>
    public ApiRequestProcessor(IOBiletV2ServiceClient oBiletV2Service, IBaseInjection baseInjection)
    {
        _oBiletV2Service = oBiletV2Service;
        _baseInjection = baseInjection;
    }

    /// <summary>
    /// Executes an API request with the specified endpoint and model.
    /// </summary>
    /// <typeparam name="T">The type to which the API response should be deserialized.</typeparam>
    /// <param name="endpoint">The API endpoint.</param>
    /// <param name="model">The model to be sent in the request body.</param>
    /// <returns>The deserialized response of type T.</returns>
    public async Task<T> Execute<T>(string endpoint, object model)
    {
        var apiUri = _oBiletV2Service.ServerUri;
        var apiKey = _baseInjection.ConfigProject.ApiInformations.AuthorizationInfo.Key;
        var apiValue = _baseInjection.ConfigProject.ApiInformations.AuthorizationInfo.Value;

        var client = _CreateRestClient(apiUri);
        var request = _CreateRestRequest(endpoint, apiKey, apiValue, model);

        RestResponse response = await client.ExecuteAsync(request);
        return _DeserializeResponse<T>(response.Content);
    }

    /// <summary>
    /// Creates a RestClient instance with the specified API URI.
    /// </summary>
    /// <param name="apiUri">The API URI.</param>
    /// <returns>A RestClient instance.</returns>
    private RestClient _CreateRestClient(string apiUri)
    {
        var options = new RestClientOptions(apiUri)
        {
            MaxTimeout = -1,
        };

        return new RestClient(options);
    }

    /// <summary>
    /// Creates a RestRequest instance with the specified endpoint, API key, API value, and model.
    /// </summary>
    /// <param name="endpoint">The API endpoint.</param>
    /// <param name="apiKey">The API key header.</param>
    /// <param name="apiValue">The API value header.</param>
    /// <param name="model">The model to be sent in the request body.</param>
    /// <returns>A RestRequest instance.</returns>
    private RestRequest _CreateRestRequest(string endpoint, string apiKey, string apiValue, object model)
    {
        var request = new RestRequest(endpoint, Method.Post);
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader(apiKey, apiValue);

        var jsonBody = JsonConvert.SerializeObject(model);
        request.AddStringBody(jsonBody, DataFormat.Json);

        return request;
    }

    /// <summary>
    /// Deserializes the API response content to the specified type.
    /// </summary>
    /// <typeparam name="T">The type to which the response content should be deserialized.</typeparam>
    /// <param name="responseContent">The response content to be deserialized.</param>
    /// <returns>The deserialized object of type T.</returns>
    private T _DeserializeResponse<T>(string responseContent)
    {
        return JsonConvert.DeserializeObject<T>(responseContent);
    }

}


