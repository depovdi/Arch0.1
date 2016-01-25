namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afdelingen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Afkorting = c.String(),
                        Naam = c.String(),
                        Manager = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bestemmingen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        RapporteringsFormulier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formulieren", t => t.RapporteringsFormulier_Id)
                .Index(t => t.RapporteringsFormulier_Id);
            
            CreateTable(
                "dbo.Betrokkenen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        RapporteringsFormulier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formulieren", t => t.RapporteringsFormulier_Id)
                .Index(t => t.RapporteringsFormulier_Id);
            
            CreateTable(
                "dbo.Cas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        RapporteringsFormulier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formulieren", t => t.RapporteringsFormulier_Id)
                .Index(t => t.RapporteringsFormulier_Id);
            
            CreateTable(
                "dbo.DetailCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Formulieren",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OpstellingsDatum = c.DateTime(nullable: false),
                        AfwerkingsDatum = c.DateTime(nullable: false),
                        OplossingsDatum = c.DateTime(nullable: false),
                        Omschrijving = c.String(),
                        AkmOmschrijving = c.String(),
                        Oplossing = c.String(),
                        Referentie = c.String(),
                        TypeRf = c.String(),
                        ClaimNummer = c.Int(nullable: false),
                        CommunicatieKlant = c.Boolean(nullable: false),
                        Qp = c.String(),
                        Kost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatieDatum = c.DateTime(nullable: false),
                        BeveiligingsIncident = c.Boolean(nullable: false),
                        ContainerNummer = c.String(),
                        TruckNummer = c.String(),
                        AantalUnits = c.Int(nullable: false),
                        Batch = c.String(),
                        SystematischeControleOpsteller = c.Boolean(nullable: false),
                        SystematischeControleOntvanger = c.Boolean(nullable: false),
                        IsSystematischeControleVolledig = c.Boolean(nullable: false),
                        ControleReferentieOpsteller = c.String(),
                        ControleReferentieOntvanger = c.String(),
                        NieuweControle = c.Boolean(nullable: false),
                        ExceptieRapporteringsNummer = c.String(),
                        IsQualityDocumentBeschreven = c.Boolean(nullable: false),
                        QualityDocumentNaam = c.String(),
                        QualityDocumentRevisie = c.Boolean(nullable: false),
                        IsNieuwQualityDocumentNodig = c.Boolean(nullable: false),
                        DoorrekenenKost = c.Boolean(nullable: false),
                        VoorstelAanvaard = c.Boolean(nullable: false),
                        OpnemenCapa = c.Boolean(nullable: false),
                        AoNummer = c.String(),
                        Gevolg = c.String(),
                        OorzaakOmschrijving = c.String(),
                        OorzaakAchterliggend = c.String(),
                        FactuurNummer = c.String(),
                        Orders = c.String(),
                        Opmerking = c.String(),
                        AuditTypeEnum = c.Int(nullable: false),
                        OngevalTypeEnum = c.Int(nullable: false),
                        Afdeling_Id = c.Int(),
                        DetailCode_Id = c.Int(),
                        HoofdCode_Id = c.Int(),
                        Ontvanger_Id = c.Int(),
                        Opsteller_Id = c.Int(),
                        Procestype_Id = c.Int(),
                        QualityProcedure_Id = c.Int(),
                        Rp_Id = c.Int(),
                        Soortklacht_Id = c.Int(),
                        Unit_Id = c.Int(),
                        Voertuig_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Afdelingen", t => t.Afdeling_Id)
                .ForeignKey("dbo.DetailCodes", t => t.DetailCode_Id)
                .ForeignKey("dbo.Klanten", t => t.HoofdCode_Id)
                .ForeignKey("dbo.Personen", t => t.Ontvanger_Id)
                .ForeignKey("dbo.Personen", t => t.Opsteller_Id)
                .ForeignKey("dbo.ProcesTypes", t => t.Procestype_Id)
                .ForeignKey("dbo.QualityProcedures", t => t.QualityProcedure_Id)
                .ForeignKey("dbo.Rps", t => t.Rp_Id)
                .ForeignKey("dbo.KlachtSoorten", t => t.Soortklacht_Id)
                .ForeignKey("dbo.Units", t => t.Unit_Id)
                .ForeignKey("dbo.Voertuigen", t => t.Voertuig_Id)
                .Index(t => t.Afdeling_Id)
                .Index(t => t.DetailCode_Id)
                .Index(t => t.HoofdCode_Id)
                .Index(t => t.Ontvanger_Id)
                .Index(t => t.Opsteller_Id)
                .Index(t => t.Procestype_Id)
                .Index(t => t.QualityProcedure_Id)
                .Index(t => t.Rp_Id)
                .Index(t => t.Soortklacht_Id)
                .Index(t => t.Unit_Id)
                .Index(t => t.Voertuig_Id);
            
            CreateTable(
                "dbo.Klanten",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HoofdCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nummer = c.Int(nullable: false),
                        Naam = c.String(),
                        RapporteringsFormulier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formulieren", t => t.RapporteringsFormulier_Id)
                .Index(t => t.RapporteringsFormulier_Id);
            
            CreateTable(
                "dbo.Locaties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Afkorting = c.String(),
                        RapporteringsFormulier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formulieren", t => t.RapporteringsFormulier_Id)
                .Index(t => t.RapporteringsFormulier_Id);
            
            CreateTable(
                "dbo.Personen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Manager = c.Boolean(nullable: false),
                        Afdeling_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Afdelingen", t => t.Afdeling_Id)
                .Index(t => t.Afdeling_Id);
            
            CreateTable(
                "dbo.Oorsprongen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        RapporteringsFormulier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formulieren", t => t.RapporteringsFormulier_Id)
                .Index(t => t.RapporteringsFormulier_Id);
            
            CreateTable(
                "dbo.Oorzaken",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        RapporteringsFormulier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formulieren", t => t.RapporteringsFormulier_Id)
                .Index(t => t.RapporteringsFormulier_Id);
            
            CreateTable(
                "dbo.ProcesTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QualityProcedures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Soorten",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Nummer = c.Int(nullable: false),
                        RapporteringsFormulier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formulieren", t => t.RapporteringsFormulier_Id)
                .Index(t => t.RapporteringsFormulier_Id);
            
            CreateTable(
                "dbo.KlachtSoorten",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Soort = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Voertuigen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Soort = c.String(),
                        Nummer = c.Int(nullable: false),
                        Merk = c.String(),
                        NummerPlaat = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Formulieren", "Voertuig_Id", "dbo.Voertuigen");
            DropForeignKey("dbo.Formulieren", "Unit_Id", "dbo.Units");
            DropForeignKey("dbo.Formulieren", "Soortklacht_Id", "dbo.KlachtSoorten");
            DropForeignKey("dbo.Soorten", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Formulieren", "Rp_Id", "dbo.Rps");
            DropForeignKey("dbo.Formulieren", "QualityProcedure_Id", "dbo.QualityProcedures");
            DropForeignKey("dbo.Formulieren", "Procestype_Id", "dbo.ProcesTypes");
            DropForeignKey("dbo.Formulieren", "Opsteller_Id", "dbo.Personen");
            DropForeignKey("dbo.Oorzaken", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Oorsprongen", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Formulieren", "Ontvanger_Id", "dbo.Personen");
            DropForeignKey("dbo.Personen", "Afdeling_Id", "dbo.Afdelingen");
            DropForeignKey("dbo.Locaties", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.HoofdCodes", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Formulieren", "HoofdCode_Id", "dbo.Klanten");
            DropForeignKey("dbo.Formulieren", "DetailCode_Id", "dbo.DetailCodes");
            DropForeignKey("dbo.Cas", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Betrokkenen", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Bestemmingen", "RapporteringsFormulier_Id", "dbo.Formulieren");
            DropForeignKey("dbo.Formulieren", "Afdeling_Id", "dbo.Afdelingen");
            DropIndex("dbo.Soorten", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Oorzaken", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Oorsprongen", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Personen", new[] { "Afdeling_Id" });
            DropIndex("dbo.Locaties", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.HoofdCodes", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Formulieren", new[] { "Voertuig_Id" });
            DropIndex("dbo.Formulieren", new[] { "Unit_Id" });
            DropIndex("dbo.Formulieren", new[] { "Soortklacht_Id" });
            DropIndex("dbo.Formulieren", new[] { "Rp_Id" });
            DropIndex("dbo.Formulieren", new[] { "QualityProcedure_Id" });
            DropIndex("dbo.Formulieren", new[] { "Procestype_Id" });
            DropIndex("dbo.Formulieren", new[] { "Opsteller_Id" });
            DropIndex("dbo.Formulieren", new[] { "Ontvanger_Id" });
            DropIndex("dbo.Formulieren", new[] { "HoofdCode_Id" });
            DropIndex("dbo.Formulieren", new[] { "DetailCode_Id" });
            DropIndex("dbo.Formulieren", new[] { "Afdeling_Id" });
            DropIndex("dbo.Cas", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Betrokkenen", new[] { "RapporteringsFormulier_Id" });
            DropIndex("dbo.Bestemmingen", new[] { "RapporteringsFormulier_Id" });
            DropTable("dbo.Voertuigen");
            DropTable("dbo.Units");
            DropTable("dbo.KlachtSoorten");
            DropTable("dbo.Soorten");
            DropTable("dbo.Rps");
            DropTable("dbo.QualityProcedures");
            DropTable("dbo.ProcesTypes");
            DropTable("dbo.Oorzaken");
            DropTable("dbo.Oorsprongen");
            DropTable("dbo.Personen");
            DropTable("dbo.Locaties");
            DropTable("dbo.HoofdCodes");
            DropTable("dbo.Klanten");
            DropTable("dbo.Formulieren");
            DropTable("dbo.DetailCodes");
            DropTable("dbo.Cas");
            DropTable("dbo.Betrokkenen");
            DropTable("dbo.Bestemmingen");
            DropTable("dbo.Afdelingen");
        }
    }
}
