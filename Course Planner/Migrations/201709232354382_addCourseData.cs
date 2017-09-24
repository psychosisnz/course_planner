namespace Course_Planner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCourseData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (CourseCode, CourseName, Description, Semester, Pre_Reqs, Compulsory, Topic) Values ('D101', 'Programming Fundamentals', 'Introduction to Programming using C#', 's2y1','', 1, 1)");
            Sql("INSERT INTO Courses (CourseCode, CourseName, Description, Semester, Pre_Reqs, Compulsory, Topic) Values ('T101', 'Network Fundamentals', 'Introduction to Networking and Cisco', 's2y1','', 1, 3)");
            Sql("INSERT INTO Courses (CourseCode, CourseName, Description, Semester, Pre_Reqs, Compulsory, Topic) Values ('I111', 'Web Fundamentals', 'Introduction to Web Development', 's2y1','', 1, 2)");
            Sql("INSERT INTO Courses (CourseCode, CourseName, Description, Semester, Pre_Reqs, Compulsory, Topic) Values ('I102', 'Technical Support Fundamentals', 'Introduction to Technical Support and ITIL', 's2y1','', 1, 2)");
            Sql("INSERT INTO Courses (CourseCode, CourseName, Description, Semester, Pre_Reqs, Compulsory, Topic) Values ('D111', 'Database Fundamentals', 'Introduction to Databases', 's1y1','', 1, 1)");
            Sql("INSERT INTO Courses (CourseCode, CourseName, Description, Semester, Pre_Reqs, Compulsory, Topic) Values ('I121', 'Systems Analysis Fundamentals', 'Introduction to Systems Analysis techniques and methods', 's1y1','', 1, 2)");
            Sql("INSERT INTO Courses (CourseCode, CourseName, Description, Semester, Pre_Reqs, Compulsory, Topic) Values ('T111', 'Computer Hardware Fundamentals', 'Introduction to Computers and how they operate', 's1y1','', 1, 3)");
            Sql("INSERT INTO Courses (CourseCode, CourseName, Description, Semester, Pre_Reqs, Compulsory, Topic) Values ('I101', 'Information System Fundamentals', 'Introduction to Information Systems', 's1y1','', 1, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
