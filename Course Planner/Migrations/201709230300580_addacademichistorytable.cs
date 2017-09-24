namespace Course_Planner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addacademichistorytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Academic_History",
                c => new
                    {
                        history_Id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        courseCode = c.String(maxLength: 128),
                        Passed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.history_Id)
                .ForeignKey("dbo.Courses", t => t.courseCode)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId)
                .Index(t => t.courseCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Academic_History", "userId", "dbo.Users");
            DropForeignKey("dbo.Academic_History", "courseCode", "dbo.Courses");
            DropIndex("dbo.Academic_History", new[] { "courseCode" });
            DropIndex("dbo.Academic_History", new[] { "userId" });
            DropTable("dbo.Academic_History");
        }
    }
}
