namespace Pccma.PraiseTeam.Database.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_PraiseTeamMember_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PraiseTeamMembers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PraiseTeamId = c.Int(nullable: false),
                        MemberName = c.String(),
                        Specialties = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PraiseTeams", t => t.PraiseTeamId, cascadeDelete: true)
                .Index(t => t.PraiseTeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PraiseTeamMembers", "PraiseTeamId", "dbo.PraiseTeams");
            DropIndex("dbo.PraiseTeamMembers", new[] { "PraiseTeamId" });
            DropTable("dbo.PraiseTeamMembers");
        }
    }
}
