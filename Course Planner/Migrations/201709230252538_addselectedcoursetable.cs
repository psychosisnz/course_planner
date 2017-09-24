namespace Course_Planner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addselectedcoursetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Selected_Course",
                c => new
                    {
                        Selection_id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        courseCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Selection_id)
                .ForeignKey("dbo.Courses", t => t.courseCode)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId)
                .Index(t => t.courseCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Selected_Course", "userId", "dbo.Users");
            DropForeignKey("dbo.Selected_Course", "courseCode", "dbo.Courses");
            DropIndex("dbo.Selected_Course", new[] { "courseCode" });
            DropIndex("dbo.Selected_Course", new[] { "userId" });
            DropTable("dbo.Selected_Course");
        }
    }
}
