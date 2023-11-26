namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Cid = c.Int(nullable: false),
                        Pid = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.Cid, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Pid, cascadeDelete: true)
                .Index(t => t.Cid)
                .Index(t => t.Pid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "Pid", "dbo.Products");
            DropForeignKey("dbo.Purchases", "Cid", "dbo.Customers");
            DropIndex("dbo.Purchases", new[] { "Pid" });
            DropIndex("dbo.Purchases", new[] { "Cid" });
            DropTable("dbo.Products");
            DropTable("dbo.Purchases");
            DropTable("dbo.Customers");
        }
    }
}
