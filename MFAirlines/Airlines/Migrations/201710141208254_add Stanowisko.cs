namespace Airlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStanowisko : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stanowisko",
                c => new
                    {
                        StanowiskoId = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.StanowiskoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stanowisko");
        }
    }
}
