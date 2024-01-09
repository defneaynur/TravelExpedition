using Core.Framework.Response;
using Microsoft.AspNetCore.Mvc;
using TravelExpedition.Api.Controllers.Processor.SessionProcessor;
using TravelExpedition.Api.Models.Request.SessionModels;
using TravelExpedition.Api.Models.Response.SessionModels;


namespace TravelExpedition.Api.Controllers
{

    public class SessionController : ControllerBase
    {
        private readonly IOBiletApiSessionProcessor _sessionProcessor;

        public SessionController(IOBiletApiSessionProcessor sessionProcessor)
        {
            _sessionProcessor = sessionProcessor;
        }

        [HttpPost]   
        public async Task<CoreResponse<SessionResponseModel>> GetSession([FromBody] SessionModel SessionModel)
        {
            var sessionData = await _sessionProcessor.GetSession(SessionModel);


            return new CoreResponse<SessionResponseModel>
            {
                ResponseCode = CoreResponseCode.Success,
                Data = sessionData,
            };
        }
    }
}
