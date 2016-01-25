namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFormulierenToBetrokkene : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Betrokkenen", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropIndex("dbo.Betrokkenen", new[] { "RapporteringsFormulier_Id" });
            CreateTable(
                "dbo.FormulierBetrokkenen",
                c => new
                    {
                        FormulierRefId = c.Int(nullable: false),
                        BetrokkeneRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FormulierRefId, t.BetrokkeneRefId })
                .ForeignKey("dbo.Formulieren", t => t.FormulierRefId, cascadeDelete: true)
                .ForeignKey("dbo.Betrokkenen", t => t.BetrokkeneRefId, cascadeDelete: true)
                .Index(t => t.FormulierRefId)
                .Index(t => t.BetrokkeneRefId);
            
            AddColumn("dbo.Formulieren", "OplossingsDatumQL", c => c.DateTime(nullable: false));
            AddColumn("dbo.Formulieren", "OntvangerQL_Id", c => c.Int());
            CreateIndex("dbo.Formulieren", "OntvangerQL_Id");
            AddForeignKey("dbo.Formulieren", "OntvangerQL_Id", "dbo.Personen", "Id");
            DropColumn("dbo.Betrokkenen", "RapporteringsFormulier_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Betrokkenen", "RapporteringsFormulier_Id", c => c.Int());
            DropForeignKey("dbo.Formulieren", "OntvangerQL_Id", "dbo.Personen");
            DropForeignKey("dbo.FormulierBetrokkenen", "BetrokkeneRefId", "dbo.Betrokkenen");
            DropForeignKey("dbo.FormulierBetrokkenen", "FormulierRefId", "dbo.Formulieren");
            DropIndex("dbo.FormulierBetrokkenen", new[] { "BetrokkeneRefId" });
            DropIndex("dbo.FormulierBetrokkenen", new[] { "FormulierRefId" });
            DropIndex("dbo.Formulieren", new[] { "OntvangerQL_Id" });
            DropColumn("dbo.Formulieren", "OntvangerQL_Id");
            DropColumn("dbo.Formulieren", "OplossingsDatumQL");
            DropTable("dbo.FormulierBetrokkenen");
            CreateIndex("dbo.Betrokkenen", "RapporteringsFormulier_Id");
            AddForeignKey("dbo.Betrokkenen", "RapporteringsFormulier_Id", "dbo.Formulieren", "Id");
        }
    }
}
