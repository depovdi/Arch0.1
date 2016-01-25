namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedOrdersToDossiernummers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "Dossiernummers", c => c.String());
            DropColumn("dbo.Formulieren", "Orders");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Formulieren", "Orders", c => c.String());
            DropColumn("dbo.Formulieren", "Dossiernummers");
        }
    }
}
