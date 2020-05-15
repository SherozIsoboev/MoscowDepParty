using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Partys.DomainObjects.Ports
{
    public interface IReadOnlyPartyRepository
    {
        Task<Party> GetParty(long id);

        Task<IEnumerable<Party>> GetAllParty();

        Task<IEnumerable<Party>> QueryParty(ICriteria<Party> criteria);

    }

    public interface IPartyRepository
    {
        Task AddParty(Party Party);

        Task RemoveParty(Party Party);

        Task UpdateParty(Party Party);
    }
}
