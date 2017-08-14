using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pccma.PraiseTeam.Database.Contracts.Repositories;

namespace Pccma.PraiseTeam.Database.Contracts
{
    public interface IPccmaPraiseTeamDataStoreContext
    {        
        Task<int> SaveChangesAsync();

        IPraiseTeamRepository PraiseTeamRepository { get; }

        IPraiseTeamMemberRepository PraiseTeamMemberRepository { get; }
    }

}
