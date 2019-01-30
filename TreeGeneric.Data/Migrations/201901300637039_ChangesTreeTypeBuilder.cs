namespace TreeGeneric.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesTreeTypeBuilder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TreeTypes", "RegionId", "dbo.Regions");
            DropIndex("dbo.TreeTypes", new[] { "RegionId" });
            CreateTable(
                "dbo.TreeTypeRegions",
                c => new
                    {
                        TreeType_Id = c.Int(nullable: false),
                        Region_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TreeType_Id, t.Region_Id })
                .ForeignKey("dbo.TreeTypes", t => t.TreeType_Id, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.Region_Id, cascadeDelete: true)
                .Index(t => t.TreeType_Id)
                .Index(t => t.Region_Id);
            
            DropColumn("dbo.TreeTypes", "RegionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TreeTypes", "RegionId", c => c.Int(nullable: false));
            DropForeignKey("dbo.TreeTypeRegions", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.TreeTypeRegions", "TreeType_Id", "dbo.TreeTypes");
            DropIndex("dbo.TreeTypeRegions", new[] { "Region_Id" });
            DropIndex("dbo.TreeTypeRegions", new[] { "TreeType_Id" });
            DropTable("dbo.TreeTypeRegions");
            CreateIndex("dbo.TreeTypes", "RegionId");
            AddForeignKey("dbo.TreeTypes", "RegionId", "dbo.Regions", "Id");
        }
    }
}
