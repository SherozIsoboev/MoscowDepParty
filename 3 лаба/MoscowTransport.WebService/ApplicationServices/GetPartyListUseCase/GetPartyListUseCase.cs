using System.Threading.Tasks;
using System.Collections.Generic;
using Partys.DomainObjects;
using Partys.DomainObjects.Ports;
using Partys.ApplicationServices.Ports;

namespace Partys.ApplicationServices.GetPartyListUseCase
{
    public class GetPartyListUseCase : IGetPartyListUseCase
    {
        private readonly IReadOnlyPartyRepository _readOnlyPartyRepository;

        public GetPartyListUseCase(IReadOnlyPartyRepository readOnlyPartyRepository) 
            => _readOnlyPartyRepository = readOnlyPartyRepository;

        public async Task<bool> Handle(GetPartyListUseCaseRequest request, IOutputPort<GetPartyListUseCaseResponse> outputPort)
        {
            IEnumerable<Party> partys = null;
            if (request.PartyId != null)
            {
                var party = await _readOnlyPartyRepository.GetParty(request.PartyId.Value);
                partys = (party != null) ? new List<Party>() { party } : new List<Party>();
                
            }
            else if (request.AreaPlace != null)
            {
                partys = await _readOnlyPartyRepository.QueryParty(new AreaPlaceCriteria(request.AreaPlace));
            }
            else
            {
                partys = await _readOnlyPartyRepository.GetAllParty();
            }
            outputPort.Handle(new GetPartyListUseCaseResponse(partys));
            return true;
        }
    }
}
