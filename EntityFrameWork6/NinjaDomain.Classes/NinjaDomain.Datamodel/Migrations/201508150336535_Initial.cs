namespace NinjaDomain.Datamodel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clans",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClanName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ninjas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ServedInOniwaban = c.Boolean(nullable: false),
                        ClanID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clans", t => t.ClanID, cascadeDelete: true)
                .Index(t => t.ClanID);
            
            CreateTable(
                "dbo.NinjaEquipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        Ninja_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ninjas", t => t.Ninja_ID, cascadeDelete: true)
                .Index(t => t.Ninja_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NinjaEquipments", "Ninja_ID", "dbo.Ninjas");
            DropForeignKey("dbo.Ninjas", "ClanID", "dbo.Clans");
            DropIndex("dbo.NinjaEquipments", new[] { "Ninja_ID" });
            DropIndex("dbo.Ninjas", new[] { "ClanID" });
            DropTable("dbo.NinjaEquipments");
            DropTable("dbo.Ninjas");
            DropTable("dbo.Clans");
        }
    }
}
