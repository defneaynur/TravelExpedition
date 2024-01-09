using Core.Framework.Response;
using Microsoft.AspNetCore.Mvc;
using TravelExpedition.Api.Controllers.Processor.SessionProcessor;
using TravelExpedition.Api.Models.Request.SessionModels;
using TravelExpedition.Api.Models.Response.SessionModels;


namespace TravelExpedition.Api.Controllers
{
    /// <summary>
    /// Controller for managing sessions.
    /// </summary>
    public class SessionController : ControllerBase
    {
        private readonly IOBiletApiSessionProcessor _sessionProcessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionController"/> class.
        /// </summary>
        /// <param name="sessionProcessor">The session processor.</param>
        public SessionController(IOBiletApiSessionProcessor sessionProcessor)
        {
            _sessionProcessor = sessionProcessor;
        }

        /// <summary>
        /// Gets the session data based on the provided session model.
        /// </summary>
        /// <param name="SessionModel">The session model.</param>
        /// <returns>Returns a task representing the asynchronous operation with the session response model.</returns>
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
