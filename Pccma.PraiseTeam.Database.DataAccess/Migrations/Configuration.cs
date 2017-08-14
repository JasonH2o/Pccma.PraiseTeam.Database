namespace Pccma.PraiseTeam.Database.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pccma.PraiseTeam.Database.DataAccess.Database.PccmaPraiseTeamDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Pccma.PraiseTeam.Database.DataAccess.Database.PccmaPraiseTeamDatabase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.PraiseTeam.AddOrUpdate(
                p => p.PraiseTeamName,
                new Model.PraiseTeam { PraiseTeamName = "H2o", TeamLeader = "David Liang" }
                );
        }
    }
}
