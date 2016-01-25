namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTypeClaimNummerToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Formulieren", "ClaimNummer", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Formulieren", "ClaimNummer", c => c.Int(nullable: false));
        }
    }
}
