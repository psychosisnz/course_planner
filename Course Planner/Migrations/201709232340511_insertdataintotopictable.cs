namespace Course_Planner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertdataintotopictable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics (TopicName) Values ('Software Development')");
            Sql("INSERT INTO Topics (TopicName) Values ('Information Management')");
            Sql("INSERT INTO Topics (TopicName) Values ('Technology')");
        }
        
        public override void Down()
        {
        }
    }
}
