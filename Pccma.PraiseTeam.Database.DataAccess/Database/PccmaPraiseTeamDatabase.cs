using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model = Pccma.PraiseTeam.Database.Model;

namespace Pccma.PraiseTeam.Database.DataAccess.Database
{
    public class PccmaPraiseTeamDatabase : DbContext
    {
        public PccmaPraiseTeamDatabase(): base("PccmaWorshipPraiseTeam")
        {
        }

        public DbSet<Model.PraiseTeam> PraiseTeam { get; set; }
        public DbSet<Model.PraiseTeamMember> PraiseTeamMember { get; set; }
    }
}
