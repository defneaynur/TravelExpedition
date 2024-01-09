using TravelExpedition.Api.Models.Request.SessionModels;
using TravelExpedition.Api.Models.Response.SessionModels;

namespace TravelExpedition.Api.Controllers.Processor.SessionProcessor
{
    public interface IOBiletApiSessionProcessor
    {
        public Task<SessionResponseModel> GetSession(SessionModel sessionModel);
    }
}
