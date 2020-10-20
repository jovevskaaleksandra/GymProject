namespace GymProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nova4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Klients", "tiptrening", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Klients", "tiptrening", c => c.String(nullable: false));
        }
    }
}
