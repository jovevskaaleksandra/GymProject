namespace GymProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Novaaa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klients", "tiptrening", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Klients", "tiptrening");
        }
    }
}
