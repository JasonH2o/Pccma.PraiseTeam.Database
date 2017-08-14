using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pccma.PraiseTeam.Database.DataAccess.Database.Maps
{
    public class PraiseTeamMap: EntityTypeConfiguration<Model.PraiseTeam>
    {
        public PraiseTeamMap()
        {
            // Primary Key
            HasKey(x => x.Id);

            // Properties
            Property(x => x.PraiseTeamName).IsRequired().HasMaxLength(256);
            Property(x => x.TeamLeader).IsOptional().HasMaxLength(256);

            // Table & Column Mappings
            ToTable("PraiseTeams");
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.PraiseTeamName).HasColumnName("PraiseTeamName");
            Property(x => x.TeamLeader).HasColumnName("TeamLeader");
        }
    }
}
