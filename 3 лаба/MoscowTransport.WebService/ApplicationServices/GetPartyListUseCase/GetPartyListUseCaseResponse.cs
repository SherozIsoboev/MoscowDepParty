using Partys.DomainObjects;
using Partys.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Partys.ApplicationServices.GetPartyListUseCase
{
    public class GetPartyListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<Party> Partys { get; }

        public GetPartyListUseCaseResponse(IEnumerable<Party> partys) => Partys = partys;
    }
}
