namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIntColumnsWithEnum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "CommunicatieKlantOpstellerEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "CommunicatieKlantOntvangerEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "SystematischeControleOpstellerEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "SystematischeControleOntvangerEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "IsSystematischeControleVolledigEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "NieuweControleEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "IsQualityDocumentBeschrevenEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "QualityDocumentRevisieEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "IsNieuwQualityDocumentNodigEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "DoorrekenenKostEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "VoorstelAanvaardEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Formulieren", "OpnemenCapaEnum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Formulieren", "OpnemenCapaEnum");
            DropColumn("dbo.Formulieren", "VoorstelAanvaardEnum");
            DropColumn("dbo.Formulieren", "DoorrekenenKostEnum");
            DropColumn("dbo.Formulieren", "IsNieuwQualityDocumentNodigEnum");
            DropColumn("dbo.Formulieren", "QualityDocumentRevisieEnum");
            DropColumn("dbo.Formulieren", "IsQualityDocumentBeschrevenEnum");
            DropColumn("dbo.Formulieren", "NieuweControleEnum");
            DropColumn("dbo.Formulieren", "IsSystematischeControleVolledigEnum");
            DropColumn("dbo.Formulieren", "SystematischeControleOntvangerEnum");
            DropColumn("dbo.Formulieren", "SystematischeControleOpstellerEnum");
            DropColumn("dbo.Formulieren", "CommunicatieKlantOntvangerEnum");
            DropColumn("dbo.Formulieren", "CommunicatieKlantOpstellerEnum");
        }
    }
}
