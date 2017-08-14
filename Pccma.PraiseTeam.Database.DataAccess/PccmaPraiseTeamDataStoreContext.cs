using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pccma.PraiseTeam.Database.Contracts;
using Pccma.PraiseTeam.Database.DataAccess.Database;
using Pccma.PraiseTeam.Database.DataAccess.Repositories;
using Pccma.PraiseTeam.Database.Contracts.Repositories;

namespace Pccma.PraiseTeam.Database.DataAccess
{
    public class PccmaPraiseTeamDataStoreContext: IPccmaPraiseTeamDataStoreContext
    {
        private PccmaPraiseTeamDatabase _pccmaPraiseTeamDatabase;

        public PccmaPraiseTeamDataStoreContext(PccmaPraiseTeamDatabase pccmaPraiseTeamDatabase)
        {
            _pccmaPraiseTeamDatabase = pccmaPraiseTeamDatabase;

            PraiseTeamRepository = new PraiseTeamRepository(_pccmaPraiseTeamDatabase);
            PraiseTeamMemberRepository = new PraiseTeamMemberRepository(_pccmaPraiseTeamDatabase);                        
        }

        public IPraiseTeamRepository PraiseTeamRepository { get; private set; }
        public IPraiseTeamMemberRepository PraiseTeamMemberRepository { get; private set; }


        public Task<int> SaveChangesAsync()
        {
            return _pccmaPraiseTeamDatabase.SaveChangesAsync();
        }
    }
}
