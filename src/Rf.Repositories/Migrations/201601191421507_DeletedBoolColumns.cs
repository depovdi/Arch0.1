namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedBoolColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "BeveiligingsIncidentEnum", c => c.Int(nullable: false));
            DropColumn("dbo.Formulieren", "CommunicatieKlantOpsteller");
            DropColumn("dbo.Formulieren", "CommunicatieKlantOntvanger");
            DropColumn("dbo.Formulieren", "SystematischeControleOpsteller");
            DropColumn("dbo.Formulieren", "SystematischeControleOntvanger");
            DropColumn("dbo.Formulieren", "IsSystematischeControleVolledig");
            DropColumn("dbo.Formulieren", "NieuweControle");
            DropColumn("dbo.Formulieren", "IsQualityDocumentBeschreven");
            DropColumn("dbo.Formulieren", "QualityDocumentRevisie");
            DropColumn("dbo.Formulieren", "IsNieuwQualityDocumentNodig");
            DropColumn("dbo.Formulieren", "DoorrekenenKost");
            DropColumn("dbo.Formulieren", "VoorstelAanvaard");
            DropColumn("dbo.Formulieren", "OpnemenCapa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Formulieren", "OpnemenCapa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "VoorstelAanvaard", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "DoorrekenenKost", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "IsNieuwQualityDocumentNodig", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "QualityDocumentRevisie", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "IsQualityDocumentBeschreven", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "NieuweControle", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "IsSystematischeControleVolledig", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "SystematischeControleOntvanger", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "SystematischeControleOpsteller", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "CommunicatieKlantOntvanger", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "CommunicatieKlantOpsteller", c => c.Boolean(nullable: false));
            DropColumn("dbo.Formulieren", "BeveiligingsIncidentEnum");
        }
    }
}
