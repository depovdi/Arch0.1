namespace Rf.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableNameCorrection : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Klanten", newName: "__mig_tmp__0");
            RenameTable(name: "dbo.HoofdCodes", newName: "Klanten");
            RenameTable(name: "__mig_tmp__0", newName: "HoofdCodes");
        }
        
        public override void Down()
        {
            RenameTable(name: "HoofdCodes", newName: "__mig_tmp__0");
            RenameTable(name: "dbo.Klanten", newName: "HoofdCodes");
            RenameTable(name: "dbo.__mig_tmp__0", newName: "Klanten");
        }
    }
}
