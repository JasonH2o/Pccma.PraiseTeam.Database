using Pccma.PraiseTeam.Database.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pccma.PraiseTeam.Database.DataAccess.Database.Maps
{
    public class PraiseTeamMemberMap: EntityTypeConfiguration<PraiseTeamMember>
    {
        public PraiseTeamMemberMap(){
            // Primary key
            HasKey(x => x.Id);

            // Properties 
            Property(x => x.MemberName).IsRequired().HasMaxLength(80);
            Property(x => x.Specialties).IsOptional().HasMaxLength(256);

            // Table & Column Mappings
            ToTable("PraiseTeamMember");
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.PraiseTeamId).HasColumnName("PraiseTeamId");
            Property(x => x.MemberName).HasColumnName("MemberName");
            Property(x => x.Specialties).HasColumnName("Specialties");

            // Relationships
            HasRequired(x => x.PraiseTeam).WithMany(x => x.PraiseTeamMembers).HasForeignKey(x => x.PraiseTeamId);
        }        
    }
}
