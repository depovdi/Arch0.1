namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OpstellerRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Formulieren", "Opsteller_Id", "dbo.Personen");
            DropIndex("dbo.Formulieren", new[] { "Opsteller_Id" });
            AlterColumn("dbo.Formulieren", "Opsteller_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Formulieren", "Opsteller_Id");
            AddForeignKey("dbo.Formulieren", "Opsteller_Id", "dbo.Personen", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Formulieren", "Opsteller_Id", "dbo.Personen");
            DropIndex("dbo.Formulieren", new[] { "Opsteller_Id" });
            AlterColumn("dbo.Formulieren", "Opsteller_Id", c => c.Int());
            CreateIndex("dbo.Formulieren", "Opsteller_Id");
            AddForeignKey("dbo.Formulieren", "Opsteller_Id", "dbo.Personen", "Id");
        }
    }
}
