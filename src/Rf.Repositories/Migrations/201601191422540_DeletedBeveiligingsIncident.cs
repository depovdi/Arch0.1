namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedBeveiligingsIncident : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Formulieren", "BeveiligingsIncident");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Formulieren", "BeveiligingsIncident", c => c.Boolean(nullable: false));
        }
    }
}
