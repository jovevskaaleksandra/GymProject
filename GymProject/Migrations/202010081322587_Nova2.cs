namespace GymProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nova2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Klients", "tipTreningZaKlient");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Klients", "tipTreningZaKlient", c => c.String(nullable: false));
        }
    }
}
