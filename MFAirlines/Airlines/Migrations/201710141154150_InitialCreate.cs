namespace Airlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        PESEL = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Course", t => t.CourseId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Kierunek",
                c => new
                    {
                        KierunekId = c.Int(nullable: false, identity: true),
                        MiejsceOdlotu = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        MiejscePrzylotu = c.String(nullable: false, maxLength: 50, fixedLength: true),
                    })
                .PrimaryKey(t => t.KierunekId);
            
            CreateTable(
                "dbo.Lot",
                c => new
                    {
                        LotId = c.Int(nullable: false, identity: true),
                        NrLotu = c.String(nullable: false, maxLength: 4, fixedLength: true),
                        KierunekId = c.Int(nullable: false),
                        SamolotId = c.Int(nullable: false),
                        ZalogaId = c.Int(nullable: false),
                        DataOdlotu = c.DateTime(nullable: false),
                        DataPrzylotu = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LotId)
                .ForeignKey("dbo.Kierunek", t => t.KierunekId, cascadeDelete: true)
                .ForeignKey("dbo.Samolot", t => t.SamolotId, cascadeDelete: true)
                .Index(t => t.KierunekId)
                .Index(t => t.SamolotId);
            
            CreateTable(
                "dbo.Odprawa",
                c => new
                    {
                        OdprawaId = c.Int(nullable: false, identity: true),
                        NumerBramki = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OdprawaId);
            
            CreateTable(
                "dbo.OdprawaPasazer",
                c => new
                    {
                        OdprawaId = c.Int(nullable: false),
                        Pesel = c.String(nullable: false, maxLength: 128),
                        Bagaz = c.Boolean(nullable: false),
                        WagaBagazu = c.Int(nullable: false),
                        CzasOdprawy = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.OdprawaId, t.Pesel })
                .ForeignKey("dbo.Odprawa", t => t.OdprawaId, cascadeDelete: true)
                .ForeignKey("dbo.Pasazer", t => t.Pesel, cascadeDelete: true)
                .Index(t => t.OdprawaId)
                .Index(t => t.Pesel);
            
            CreateTable(
                "dbo.Pasazer",
                c => new
                    {
                        Pesel = c.String(nullable: false, maxLength: 128),
                        Adres = c.String(),
                        Kraj = c.String(),
                    })
                .PrimaryKey(t => t.Pesel);
            
            CreateTable(
                "dbo.Samolot",
                c => new
                    {
                        SamolotId = c.Int(nullable: false, identity: true),
                        NrSeryjny = c.String(nullable: false, maxLength: 5, fixedLength: true),
                        TypId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SamolotId)
                .ForeignKey("dbo.TypSamolotu", t => t.TypId, cascadeDelete: true)
                .Index(t => t.TypId);
            
            CreateTable(
                "dbo.TypSamolotu",
                c => new
                    {
                        TypId = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        IloscMiejsc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TypId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Samolot", "TypId", "dbo.TypSamolotu");
            DropForeignKey("dbo.Lot", "SamolotId", "dbo.Samolot");
            DropForeignKey("dbo.OdprawaPasazer", "Pesel", "dbo.Pasazer");
            DropForeignKey("dbo.OdprawaPasazer", "OdprawaId", "dbo.Odprawa");
            DropForeignKey("dbo.Lot", "KierunekId", "dbo.Kierunek");
            DropForeignKey("dbo.Student", "CourseId", "dbo.Course");
            DropIndex("dbo.Samolot", new[] { "TypId" });
            DropIndex("dbo.OdprawaPasazer", new[] { "Pesel" });
            DropIndex("dbo.OdprawaPasazer", new[] { "OdprawaId" });
            DropIndex("dbo.Lot", new[] { "SamolotId" });
            DropIndex("dbo.Lot", new[] { "KierunekId" });
            DropIndex("dbo.Student", new[] { "CourseId" });
            DropTable("dbo.TypSamolotu");
            DropTable("dbo.Samolot");
            DropTable("dbo.Pasazer");
            DropTable("dbo.OdprawaPasazer");
            DropTable("dbo.Odprawa");
            DropTable("dbo.Lot");
            DropTable("dbo.Kierunek");
            DropTable("dbo.Student");
            DropTable("dbo.Course");
        }
    }
}
