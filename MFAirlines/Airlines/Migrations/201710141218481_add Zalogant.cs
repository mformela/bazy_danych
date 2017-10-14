namespace Airlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addZalogant : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zalogant",
                c => new
                    {
                        ZalogantId = c.Int(nullable: false, identity: true),
                        PESEL = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        DataZatrudnienia = c.DateTime(nullable: false),
                        Adres = c.String(nullable: false, maxLength: 100),
                        NrTelefonu = c.String(nullable: false, maxLength: 11),
                        StanowiskokId = c.Int(nullable: false),
                        ZalogaId = c.Int(nullable: false),
                        Stanowisko_StanowiskoId = c.Int(),
                    })
                .PrimaryKey(t => t.ZalogantId)
                .ForeignKey("dbo.Stanowisko", t => t.Stanowisko_StanowiskoId)
                .Index(t => t.Stanowisko_StanowiskoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zalogant", "Stanowisko_StanowiskoId", "dbo.Stanowisko");
            DropIndex("dbo.Zalogant", new[] { "Stanowisko_StanowiskoId" });
            DropTable("dbo.Zalogant");
        }
    }
}
