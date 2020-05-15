using Partys.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Partys.ApplicationServices.GetPartyListUseCase
{
    public class GetPartyListUseCaseRequest : IUseCaseRequest<GetPartyListUseCaseResponse>
    {
        public string AreaPlace { get; private set; }
        public long? PartyId { get; private set; }

        private GetPartyListUseCaseRequest()
        { }

        public static GetPartyListUseCaseRequest CreateAllPartysRequest()
        {
            return new GetPartyListUseCaseRequest();
        }

        public static GetPartyListUseCaseRequest CreatePatyRequest(long partyId)
        {
            return new GetPartyListUseCaseRequest() { PartyId = partyId };
        }
        public static GetPartyListUseCaseRequest CreateAreaPlacePartysRequest(string areaplace)
        {
            return new GetPartyListUseCaseRequest() { AreaPlace = areaplace  };
        }
    }
}
