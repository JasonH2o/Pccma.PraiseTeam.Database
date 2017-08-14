using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pccma.PraiseTeam.Database.Model
{
    public class PraiseTeam : PrimaryKeyObject
    {
        public string PraiseTeamName { get; set; }
        public string TeamLeader { get; set; }

        public ICollection<PraiseTeamMember> PraiseTeamMembers { get; set; }
    }
}
