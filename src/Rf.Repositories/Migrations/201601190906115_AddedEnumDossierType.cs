namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEnumDossierType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "DossierTypeEnum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Formulieren", "DossierTypeEnum");
        }
    }
}
