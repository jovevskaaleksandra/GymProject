namespace GymProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nova3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Klients", "telefonskiBrojKlient", c => c.String(nullable: false, maxLength: 9));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Klients", "telefonskiBrojKlient", c => c.Int(nullable: false));
        }
    }
}
