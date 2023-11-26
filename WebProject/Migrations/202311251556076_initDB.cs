namespace WebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        uname = c.String(nullable: false, maxLength: 128),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.uname);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
