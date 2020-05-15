using Partys.DomainObjects;
using Partys.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Partys.ApplicationServices.GetPartyListUseCase
{
    public class GetParyListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<Party> Partys { get; }

        public GetParyListUseCaseResponse(IEnumerable<Party> partys) => Partys = partys;
    }
}
