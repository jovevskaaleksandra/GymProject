namespace GymProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nova : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Klients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nameKlient = c.String(nullable: false),
                        heightKlient = c.Int(nullable: false),
                        weightKlient = c.Int(nullable: false),
                        kolkuPatiMesecno = c.Int(nullable: false),
                        telefonskiBrojKlient = c.Int(nullable: false),
                        addressKlient = c.String(nullable: false),
                        tipTreningZaKlient = c.String(nullable: false),
                        clenskaKartaKlient = c.Int(nullable: false),
                        trenerZaKlient_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Treners", t => t.trenerZaKlient_Id, cascadeDelete: true)
                .Index(t => t.trenerZaKlient_Id);
            
            CreateTable(
                "dbo.Treners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        brojNaKlienti = c.Int(nullable: false),
                        nameVraboten = c.String(),
                        emailVraboten = c.String(),
                        kodVraboten = c.Int(nullable: false),
                        telefonskiBrojVraboten = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Klients", "trenerZaKlient_Id", "dbo.Treners");
            DropIndex("dbo.Klients", new[] { "trenerZaKlient_Id" });
            DropTable("dbo.Treners");
            DropTable("dbo.Klients");
        }
    }
}
