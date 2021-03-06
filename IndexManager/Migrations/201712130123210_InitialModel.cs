namespace IndexManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Indices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SqlCommand = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Columns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Table_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tables", t => t.Table_Id)
                .Index(t => t.Table_Id);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IndexCases",
                c => new
                    {
                        Index_Id = c.Int(nullable: false),
                        Case_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Index_Id, t.Case_Id })
                .ForeignKey("dbo.Indices", t => t.Index_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cases", t => t.Case_Id, cascadeDelete: true)
                .Index(t => t.Index_Id)
                .Index(t => t.Case_Id);
            
            CreateTable(
                "dbo.ColumnIndexes",
                c => new
                    {
                        Column_Id = c.Int(nullable: false),
                        Index_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Column_Id, t.Index_Id })
                .ForeignKey("dbo.Columns", t => t.Column_Id, cascadeDelete: true)
                .ForeignKey("dbo.Indices", t => t.Index_Id, cascadeDelete: true)
                .Index(t => t.Column_Id)
                .Index(t => t.Index_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Columns", "Table_Id", "dbo.Tables");
            DropForeignKey("dbo.ColumnIndexes", "Index_Id", "dbo.Indices");
            DropForeignKey("dbo.ColumnIndexes", "Column_Id", "dbo.Columns");
            DropForeignKey("dbo.IndexCases", "Case_Id", "dbo.Cases");
            DropForeignKey("dbo.IndexCases", "Index_Id", "dbo.Indices");
            DropIndex("dbo.ColumnIndexes", new[] { "Index_Id" });
            DropIndex("dbo.ColumnIndexes", new[] { "Column_Id" });
            DropIndex("dbo.IndexCases", new[] { "Case_Id" });
            DropIndex("dbo.IndexCases", new[] { "Index_Id" });
            DropIndex("dbo.Columns", new[] { "Table_Id" });
            DropTable("dbo.ColumnIndexes");
            DropTable("dbo.IndexCases");
            DropTable("dbo.Tables");
            DropTable("dbo.Columns");
            DropTable("dbo.Indices");
            DropTable("dbo.Cases");
        }
    }
}
