using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pccma.PraiseTeam.Database.Model
{
    public class PraiseTeamMember:PrimaryKeyObject
    {
        public int PraiseTeamId { get; set; }

        public PraiseTeam PraiseTeam { get; set; }

        public string MemberName { get; set; }

        public string Specialties { get; set; }            
    }
}
