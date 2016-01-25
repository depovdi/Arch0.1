namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedKlachtGeuitDoor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "KlachtGeuitDoor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Formulieren", "KlachtGeuitDoor");
        }
    }
}
