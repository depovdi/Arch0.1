namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedOpstellingsDatum : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Formulieren", "OpstellingsDatum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Formulieren", "OpstellingsDatum", c => c.DateTime());
        }
    }
}
