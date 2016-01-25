namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVaststellingsDatumToFormulier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "VaststellingsDatum", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Formulieren", "VaststellingsDatum");
        }
    }
}
