namespace SchoolProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eewfewq : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses");
            DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Course_Id" });
            CreateTable(
                "dbo.StudentPerCourses",
                c => new
                    {
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentID, t.CourseID })
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
            AddColumn("dbo.Students", "Course_Id", c => c.Int());
            CreateIndex("dbo.Students", "Course_Id");
            AddForeignKey("dbo.Students", "Course_Id", "dbo.Courses", "Id");
            DropTable("dbo.StudentCourses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Course_Id });
            
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.StudentPerCourses", "StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentPerCourses", "CourseID", "dbo.Courses");
            DropIndex("dbo.StudentPerCourses", new[] { "CourseID" });
            DropIndex("dbo.StudentPerCourses", new[] { "StudentID" });
            DropIndex("dbo.Students", new[] { "Course_Id" });
            DropColumn("dbo.Students", "Course_Id");
            DropTable("dbo.StudentPerCourses");
            CreateIndex("dbo.StudentCourses", "Course_Id");
            CreateIndex("dbo.StudentCourses", "Student_Id");
            AddForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
