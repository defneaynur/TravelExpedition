using Core.Config.Injection;
using Core.Config.Config;
using TravelExpedition.Api.ServiceClient;
using TravelExpedition.Api.Controllers.Processor.SessionProcessor;
using TravelExpedition.Api.Controllers.Processor.ApiProcesser;
using TravelExpedition.Api.Controllers.Processor.Request;

namespace TravelExpedition.Api.Base;

public static class ConfigureInjection
{
	public static void BaseInject(this WebApplicationBuilder builder)
	{
		builder.BaseDefaultInjection();

        builder.Services.AddScoped<IApiRequestProcessor, ApiRequestProcessor>();
        builder.Services.AddScoped<IOBiletApiTravelProcessor, OBiletApiTravelProcessor>();
		builder.Services.AddScoped<IOBiletApiSessionProcessor, OBiletApiSessionProcessor>();
        builder.GetServiceClients();
    }
    private static void GetServiceClients(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IOBiletV2ServiceClient, OBiletV2ServiceClient>(c =>
        {
            var httpContextAccessor = c.GetService<IHttpContextAccessor>();
            var apiUri = c.GetConnectedProjectServerUriFromInjection("obilet.apiV2");
            return new OBiletV2ServiceClient(httpContextAccessor, apiUri);
        });
    }
}
