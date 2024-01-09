namespace TravelExpedition.Api.Controllers.Processor.Request;
public interface IApiRequestProcessor
{
    Task<T> Execute<T>(string endpoint, object model);
}


