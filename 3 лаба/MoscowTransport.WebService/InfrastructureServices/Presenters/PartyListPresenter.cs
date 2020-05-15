using Partys.ApplicationServices.GetPartyListUseCase;
using System.Net;
using Newtonsoft.Json;
using Partys.ApplicationServices.Ports;

namespace Partys.InfrastructureServices.Presenters
{ 
    public class PartyListPresenter : IOutputPort<GetPartyListUseCaseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public PartyListPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetPartyListUseCaseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.NotFound);
            ContentResult.Content = response.Success ? JsonConvert.SerializeObject(response.Partys) : JsonConvert.SerializeObject(response.Message);
        }
    }
}
