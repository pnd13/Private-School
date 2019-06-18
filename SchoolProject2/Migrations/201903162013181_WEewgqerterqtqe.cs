namespace SchoolProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WEewgqerterqtqe : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentPerCourses", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.StudentPerCourses", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "Course_Id" });
            DropIndex("dbo.StudentPerCourses", new[] { "StudentID" });
            DropIndex("dbo.StudentPerCourses", new[] { "CourseID" });
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Course_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Course_Id);
            
            DropColumn("dbo.Students", "Course_Id");
            DropTable("dbo.StudentPerCourses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentPerCourses",
                c => new
                    {
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentID, t.CourseID });
            
            AddColumn("dbo.Students", "Course_Id", c => c.Int());
            DropForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentCourses", new[] { "Course_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            DropTable("dbo.StudentCourses");
            CreateIndex("dbo.StudentPerCourses", "CourseID");
            CreateIndex("dbo.StudentPerCourses", "StudentID");
            CreateIndex("dbo.Students", "Course_Id");
            AddForeignKey("dbo.Students", "Course_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.StudentPerCourses", "StudentID", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentPerCourses", "CourseID", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}
