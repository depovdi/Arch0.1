namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLeverancierToFormulier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "Leverancier", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Formulieren", "Leverancier");
        }
    }
}
