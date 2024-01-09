
namespace TravelExpedition.Api.ServiceClient
{
    public class OBiletV2ServiceClient : IOBiletV2ServiceClient
    {
        public string ServerUri { get; set; }
        public OBiletV2ServiceClient(IHttpContextAccessor httpContext, string uri) 
        {
            ServerUri = uri;
        }
    }
    public interface IOBiletV2ServiceClient 
    {
        public string ServerUri { get; set; }
    }
}
