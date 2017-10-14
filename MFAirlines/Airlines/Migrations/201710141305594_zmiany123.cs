namespace Airlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmiany123 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Zalogant", "Stanowisko_StanowiskoId", "dbo.Stanowisko");
            DropIndex("dbo.Zalogant", new[] { "Stanowisko_StanowiskoId" });
            RenameColumn(table: "dbo.Zalogant", name: "Stanowisko_StanowiskoId", newName: "StanowiskoId");
            AlterColumn("dbo.Zalogant", "StanowiskoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Zalogant", "StanowiskoId");
            AddForeignKey("dbo.Zalogant", "StanowiskoId", "dbo.Stanowisko", "StanowiskoId", cascadeDelete: true);
            DropColumn("dbo.Zalogant", "StanowiskokId");
            DropColumn("dbo.Zalogant", "ZalogaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Zalogant", "ZalogaId", c => c.Int(nullable: false));
            AddColumn("dbo.Zalogant", "StanowiskokId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Zalogant", "StanowiskoId", "dbo.Stanowisko");
            DropIndex("dbo.Zalogant", new[] { "StanowiskoId" });
            AlterColumn("dbo.Zalogant", "StanowiskoId", c => c.Int());
            RenameColumn(table: "dbo.Zalogant", name: "StanowiskoId", newName: "Stanowisko_StanowiskoId");
            CreateIndex("dbo.Zalogant", "Stanowisko_StanowiskoId");
            AddForeignKey("dbo.Zalogant", "Stanowisko_StanowiskoId", "dbo.Stanowisko", "StanowiskoId");
        }
    }
}
