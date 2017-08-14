namespace Pccma.PraiseTeam.Database.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PraiseTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PraiseTeamName = c.String(),
                        TeamLeader = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PraiseTeams");
        }
    }
}
