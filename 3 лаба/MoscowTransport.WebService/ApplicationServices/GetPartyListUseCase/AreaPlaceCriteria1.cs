using Partys.DomainObjects;
using Partys.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Partys.ApplicationServices.GetPartyListUseCase
{
    public class AreaPlaceCriteria : ICriteria<Party>
    {
        public string AreaPlace { get; }

        public AreaPlaceCriteria(string areaplace)
            => AreaPlace = areaplace;

        public Expression<Func<Party, bool>> Filter
            => (Pr => Pr.AreaPlace == AreaPlace);
    }
}
