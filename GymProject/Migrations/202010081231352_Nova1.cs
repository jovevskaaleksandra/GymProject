namespace GymProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nova1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Treners", "nameVraboten", c => c.String(nullable: false));
            AlterColumn("dbo.Treners", "emailVraboten", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Treners", "emailVraboten", c => c.String());
            AlterColumn("dbo.Treners", "nameVraboten", c => c.String());
        }
    }
}
