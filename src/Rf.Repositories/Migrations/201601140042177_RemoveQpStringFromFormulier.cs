namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveQpStringFromFormulier : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Formulieren", "Qp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Formulieren", "Qp", c => c.String());
        }
    }
}
