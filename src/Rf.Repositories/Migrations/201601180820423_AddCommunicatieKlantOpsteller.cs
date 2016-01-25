namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCommunicatieKlantOpsteller : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "CommunicatieKlantOpsteller", c => c.Boolean(nullable: false));
            AddColumn("dbo.Formulieren", "CommunicatieKlantOntvanger", c => c.Boolean(nullable: false));
            DropColumn("dbo.Formulieren", "CommunicatieKlant");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Formulieren", "CommunicatieKlant", c => c.Boolean(nullable: false));
            DropColumn("dbo.Formulieren", "CommunicatieKlantOntvanger");
            DropColumn("dbo.Formulieren", "CommunicatieKlantOpsteller");
        }
    }
}
