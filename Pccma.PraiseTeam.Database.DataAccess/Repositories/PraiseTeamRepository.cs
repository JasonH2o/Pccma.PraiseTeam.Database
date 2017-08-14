using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pccma.PraiseTeam.Database.Contracts.Repositories;
using Model = Pccma.PraiseTeam.Database.Model;
using Pccma.PraiseTeam.Database.DataAccess.Database;

namespace Pccma.PraiseTeam.Database.DataAccess.Repositories
{
    public class PraiseTeamRepository: RepositoryBase<Model.PraiseTeam>, IPraiseTeamRepository
    {
        public PraiseTeamRepository(PccmaPraiseTeamDatabase pccmaPraiseTeamDatabase)
            : base(pccmaPraiseTeamDatabase, pccmaPraiseTeamDatabase.PraiseTeam)
        {
        }
    }
}
