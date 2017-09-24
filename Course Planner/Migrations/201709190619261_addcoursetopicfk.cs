namespace Course_Planner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcoursetopicfk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Topic", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "Topic");
            AddForeignKey("dbo.Courses", "Topic", "dbo.Topics", "Topic", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Topic", "dbo.Topics");
            DropIndex("dbo.Courses", new[] { "Topic" });
            AlterColumn("dbo.Courses", "Topic", c => c.String());
        }
    }
}
