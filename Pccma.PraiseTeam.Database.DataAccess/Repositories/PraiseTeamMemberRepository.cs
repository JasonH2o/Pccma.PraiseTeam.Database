using Pccma.PraiseTeam.Database.Contracts.Repositories;
using Pccma.PraiseTeam.Database.DataAccess.Database;
using Pccma.PraiseTeam.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pccma.PraiseTeam.Database.DataAccess.Repositories
{
    public class PraiseTeamMemberRepository: RepositoryBase<PraiseTeamMember>, IPraiseTeamMemberRepository
    {
        public PraiseTeamMemberRepository(PccmaPraiseTeamDatabase pccmaPraiseTeamDatabase)
            : base(pccmaPraiseTeamDatabase, pccmaPraiseTeamDatabase.PraiseTeamMember)
        {
        }        
    }
}
