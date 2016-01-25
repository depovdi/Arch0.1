namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableDates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Formulieren", "OpstellingsDatum", c => c.DateTime());
            AlterColumn("dbo.Formulieren", "AfwerkingsDatum", c => c.DateTime());
            AlterColumn("dbo.Formulieren", "OplossingsDatum", c => c.DateTime());
            AlterColumn("dbo.Formulieren", "OplossingsDatumQL", c => c.DateTime());
            AlterColumn("dbo.Formulieren", "CreatieDatum", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Formulieren", "CreatieDatum", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Formulieren", "OplossingsDatumQL", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Formulieren", "OplossingsDatum", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Formulieren", "AfwerkingsDatum", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Formulieren", "OpstellingsDatum", c => c.DateTime(nullable: false));
        }
    }
}
