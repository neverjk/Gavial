namespace GavialServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gavial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Money = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                        BadWords = c.Int(nullable: false),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
        }
    }
}
