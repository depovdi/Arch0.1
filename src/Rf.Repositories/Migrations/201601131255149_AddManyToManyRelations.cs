namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManyToManyRelations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bestemmingen", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Cas", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.HoofdCodes", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Locaties", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Oorsprongen", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Oorzaken", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Soorten", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropIndex("dbo.Bestemmingen", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Cas", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.HoofdCodes", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Locaties", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Oorsprongen", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Oorzaken", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Soorten", new[] { "RapporteringsFormulier_Id" });
            CreateTable(
                "dbo.FormulierBestemmingen",
                c => new
                    {
                        FormulierRefId = c.Int(nullable: false),
                        BestemmingenRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FormulierRefId, t.BestemmingenRefId })
                .ForeignKey("dbo.Formulieren", t => t.FormulierRefId, cascadeDelete: true)
                .ForeignKey("dbo.Bestemmingen", t => t.BestemmingenRefId, cascadeDelete: true)
                .Index(t => t.FormulierRefId)
                .Index(t => t.BestemmingenRefId);
            
            CreateTable(
                "dbo.FormulierCas",
                c => new
                    {
                        FormulierRefId = c.Int(nullable: false),
                        CasRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FormulierRefId, t.CasRefId })
                .ForeignKey("dbo.Formulieren", t => t.FormulierRefId, cascadeDelete: true)
                .ForeignKey("dbo.Cas", t => t.CasRefId, cascadeDelete: true)
                .Index(t => t.FormulierRefId)
                .Index(t => t.CasRefId);
            
            CreateTable(
                "dbo.FormulierKlanten",
                c => new
                    {
                        FormulierRefId = c.Int(nullable: false),
                        KlantenRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FormulierRefId, t.KlantenRefId })
                .ForeignKey("dbo.Formulieren", t => t.FormulierRefId, cascadeDelete: true)
                .ForeignKey("dbo.HoofdCodes", t => t.KlantenRefId, cascadeDelete: true)
                .Index(t => t.FormulierRefId)
                .Index(t => t.KlantenRefId);
            
            CreateTable(
                "dbo.FormulierLocaties",
                c => new
                    {
                        FormulierRefId = c.Int(nullable: false),
                        LocatiesRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FormulierRefId, t.LocatiesRefId })
                .ForeignKey("dbo.Formulieren", t => t.FormulierRefId, cascadeDelete: true)
                .ForeignKey("dbo.Locaties", t => t.LocatiesRefId, cascadeDelete: true)
                .Index(t => t.FormulierRefId)
                .Index(t => t.LocatiesRefId);
            
            CreateTable(
                "dbo.FormulierOorsprongen",
                c => new
                    {
                        FormulierRefId = c.Int(nullable: false),
                        OorsprongenRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FormulierRefId, t.OorsprongenRefId })
                .ForeignKey("dbo.Formulieren", t => t.FormulierRefId, cascadeDelete: true)
                .ForeignKey("dbo.Oorsprongen", t => t.OorsprongenRefId, cascadeDelete: true)
                .Index(t => t.FormulierRefId)
                .Index(t => t.OorsprongenRefId);
            
            CreateTable(
                "dbo.FormulierOorzaken",
                c => new
                    {
                        FormulierRefId = c.Int(nullable: false),
                        OorzakenRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FormulierRefId, t.OorzakenRefId })
                .ForeignKey("dbo.Formulieren", t => t.FormulierRefId, cascadeDelete: true)
                .ForeignKey("dbo.Oorzaken", t => t.OorzakenRefId, cascadeDelete: true)
                .Index(t => t.FormulierRefId)
                .Index(t => t.OorzakenRefId);
            
            CreateTable(
                "dbo.FormulierSoorten",
                c => new
                    {
                        FormulierRefId = c.Int(nullable: false),
                        SoortenRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FormulierRefId, t.SoortenRefId })
                .ForeignKey("dbo.Formulieren", t => t.FormulierRefId, cascadeDelete: true)
                .ForeignKey("dbo.Soorten", t => t.SoortenRefId, cascadeDelete: true)
                .Index(t => t.FormulierRefId)
                .Index(t => t.SoortenRefId);
            
            DropColumn("dbo.Bestemmingen", "RapporteringsFormulier_Id");
            DropColumn("dbo.Cas", "RapporteringsFormulier_Id");
            DropColumn("dbo.HoofdCodes", "RapporteringsFormulier_Id");
            DropColumn("dbo.Locaties", "RapporteringsFormulier_Id");
            DropColumn("dbo.Oorsprongen", "RapporteringsFormulier_Id");
            DropColumn("dbo.Oorzaken", "RapporteringsFormulier_Id");
            DropColumn("dbo.Soorten", "RapporteringsFormulier_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Soorten", "RapporteringsFormulier_Id", c => c.Int());
            AddColumn("dbo.Oorzaken", "RapporteringsFormulier_Id", c => c.Int());
            AddColumn("dbo.Oorsprongen", "RapporteringsFormulier_Id", c => c.Int());
            AddColumn("dbo.Locaties", "RapporteringsFormulier_Id", c => c.Int());
            AddColumn("dbo.HoofdCodes", "RapporteringsFormulier_Id", c => c.Int());
            AddColumn("dbo.Cas", "RapporteringsFormulier_Id", c => c.Int());
            AddColumn("dbo.Bestemmingen", "RapporteringsFormulier_Id", c => c.Int());
            DropForeignKey("dbo.FormulierSoorten", "SoortenRefId", "dbo.Soorten");
            DropForeignKey("dbo.FormulierSoorten", "FormulierRefId", "dbo.Formulieren");
            DropForeignKey("dbo.FormulierOorzaken", "OorzakenRefId", "dbo.Oorzaken");
            DropForeignKey("dbo.FormulierOorzaken", "FormulierRefId", "dbo.Formulieren");
            DropForeignKey("dbo.FormulierOorsprongen", "OorsprongenRefId", "dbo.Oorsprongen");
            DropForeignKey("dbo.FormulierOorsprongen", "FormulierRefId", "dbo.Formulieren");
            DropForeignKey("dbo.FormulierLocaties", "LocatiesRefId", "dbo.Locaties");
            DropForeignKey("dbo.FormulierLocaties", "FormulierRefId", "dbo.Formulieren");
            DropForeignKey("dbo.FormulierKlanten", "KlantenRefId", "dbo.HoofdCodes");
            DropForeignKey("dbo.FormulierKlanten", "FormulierRefId", "dbo.Formulieren");
            DropForeignKey("dbo.FormulierCas", "CasRefId", "dbo.Cas");
            DropForeignKey("dbo.FormulierCas", "FormulierRefId", "dbo.Formulieren");
            DropForeignKey("dbo.FormulierBestemmingen", "BestemmingenRefId", "dbo.Bestemmingen");
            DropForeignKey("dbo.FormulierBestemmingen", "FormulierRefId", "dbo.Formulieren");
            DropIndex("dbo.FormulierSoorten", new[] { "SoortenRefId" });
            DropIndex("dbo.FormulierSoorten", new[] { "FormulierRefId" });
            DropIndex("dbo.FormulierOorzaken", new[] { "OorzakenRefId" });
            DropIndex("dbo.FormulierOorzaken", new[] { "FormulierRefId" });
            DropIndex("dbo.FormulierOorsprongen", new[] { "OorsprongenRefId" });
            DropIndex("dbo.FormulierOorsprongen", new[] { "FormulierRefId" });
            DropIndex("dbo.FormulierLocaties", new[] { "LocatiesRefId" });
            DropIndex("dbo.FormulierLocaties", new[] { "FormulierRefId" });
            DropIndex("dbo.FormulierKlanten", new[] { "KlantenRefId" });
            DropIndex("dbo.FormulierKlanten", new[] { "FormulierRefId" });
            DropIndex("dbo.FormulierCas", new[] { "CasRefId" });
            DropIndex("dbo.FormulierCas", new[] { "FormulierRefId" });
            DropIndex("dbo.FormulierBestemmingen", new[] { "BestemmingenRefId" });
            DropIndex("dbo.FormulierBestemmingen", new[] { "FormulierRefId" });
            DropTable("dbo.FormulierSoorten");
            DropTable("dbo.FormulierOorzaken");
            DropTable("dbo.FormulierOorsprongen");
            DropTable("dbo.FormulierLocaties");
            DropTable("dbo.FormulierKlanten");
            DropTable("dbo.FormulierCas");
            DropTable("dbo.FormulierBestemmingen");
            CreateIndex("dbo.Soorten", "RapporteringsFormulier_Id");
            CreateIndex("dbo.Oorzaken", "RapporteringsFormulier_Id");
            CreateIndex("dbo.Oorsprongen", "RapporteringsFormulier_Id");
            CreateIndex("dbo.Locaties", "RapporteringsFormulier_Id");
            CreateIndex("dbo.HoofdCodes", "RapporteringsFormulier_Id");
            CreateIndex("dbo.Cas", "RapporteringsFormulier_Id");
            CreateIndex("dbo.Bestemmingen", "RapporteringsFormulier_Id");
            AddForeignKey("dbo.Soorten", "RapporteringsFormulier_Id", "dbo.Formulieren", "Id");
            AddForeignKey("dbo.Oorzaken", "RapporteringsFormulier_Id", "dbo.Formulieren", "Id");
            AddForeignKey("dbo.Oorsprongen", "RapporteringsFormulier_Id", "dbo.Formulieren", "Id");
            AddForeignKey("dbo.Locaties", "RapporteringsFormulier_Id", "dbo.Formulieren", "Id");
            AddForeignKey("dbo.HoofdCodes", "RapporteringsFormulier_Id", "dbo.Formulieren", "Id");
            AddForeignKey("dbo.Cas", "RapporteringsFormulier_Id", "dbo.Formulieren", "Id");
            AddForeignKey("dbo.Bestemmingen", "RapporteringsFormulier_Id", "dbo.Formulieren", "Id");
        }
    }
}
