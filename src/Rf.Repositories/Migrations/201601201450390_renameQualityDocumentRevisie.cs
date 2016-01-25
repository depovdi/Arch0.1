namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameQualityDocumentRevisie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "IsQualityDocumentVolledig", c => c.Int(nullable: false));
            DropColumn("dbo.Formulieren", "QualityDocumentRevisie");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Formulieren", "QualityDocumentRevisie", c => c.Int(nullable: false));
            DropColumn("dbo.Formulieren", "IsQualityDocumentVolledig");
        }
    }
}
