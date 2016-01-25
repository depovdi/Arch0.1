namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStatusRf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formulieren", "StatusRfEnum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Formulieren", "StatusRfEnum");
        }
    }
}
