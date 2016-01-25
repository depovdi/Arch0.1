namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameBooleanEnumColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "CommunicatieKlantOpsteller", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "CommunicatieKlantOntvanger", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "BeveiligingsIncident", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "SystematischeControleOpsteller", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "SystematischeControleOntvanger", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "IsSystematischeControleVolledig", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "NieuweControle", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "IsQualityDocumentBeschreven", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "QualityDocumentRevisie", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "IsNieuwQualityDocumentNodig", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "DoorrekenenKost", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "VoorstelAanvaard", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "OpnemenCapa", c => c.Int(nullable: false));
            DropColumn("dbo.Formulieren", "CommunicatieKlantOpstellerEnum");
            DropColumn("dbo.Formulieren", "CommunicatieKlantOntvangerEnum");
            DropColumn("dbo.Formulieren", "BeveiligingsIncidentEnum");
            DropColumn("dbo.Formulieren", "SystematischeControleOpstellerEnum");
            DropColumn("dbo.Formulieren", "SystematischeControleOntvangerEnum");
            DropColumn("dbo.Formulieren", "IsSystematischeControleVolledigEnum");
            DropColumn("dbo.Formulieren", "NieuweControleEnum");
            DropColumn("dbo.Formulieren", "IsQualityDocumentBeschrevenEnum");
            DropColumn("dbo.Formulieren", "QualityDocumentRevisieEnum");
            DropColumn("dbo.Formulieren", "IsNieuwQualityDocumentNodigEnum");
            DropColumn("dbo.Formulieren", "DoorrekenenKostEnum");
            DropColumn("dbo.Formulieren", "VoorstelAanvaardEnum");
            DropColumn("dbo.Formulieren", "OpnemenCapaEnum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Formulieren", "OpnemenCapaEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "VoorstelAanvaardEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "DoorrekenenKostEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "IsNieuwQualityDocumentNodigEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "QualityDocumentRevisieEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "IsQualityDocumentBeschrevenEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "NieuweControleEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "IsSystematischeControleVolledigEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "SystematischeControleOntvangerEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "SystematischeControleOpstellerEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "BeveiligingsIncidentEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "CommunicatieKlantOntvangerEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "CommunicatieKlantOpstellerEnum", c => c.Int(nullable: false));
            DropColumn("dbo.Formulieren", "OpnemenCapa");
            DropColumn("dbo.Formulieren", "VoorstelAanvaard");
            DropColumn("dbo.Formulieren", "DoorrekenenKost");
            DropColumn("dbo.Formulieren", "IsNieuwQualityDocumentNodig");
            DropColumn("dbo.Formulieren", "QualityDocumentRevisie");
            DropColumn("dbo.Formulieren", "IsQualityDocumentBeschreven");
            DropColumn("dbo.Formulieren", "NieuweControle");
            DropColumn("dbo.Formulieren", "IsSystematischeControleVolledig");
            DropColumn("dbo.Formulieren", "SystematischeControleOntvanger");
            DropColumn("dbo.Formulieren", "SystematischeControleOpsteller");
            DropColumn("dbo.Formulieren", "BeveiligingsIncident");
            DropColumn("dbo.Formulieren", "CommunicatieKlantOntvanger");
            DropColumn("dbo.Formulieren", "CommunicatieKlantOpsteller");
        }
    }
}
