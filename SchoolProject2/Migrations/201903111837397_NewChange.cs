namespace SchoolProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses");
            DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Course_Id" });
            AddColumn("dbo.Courses", "Student_Id", c => c.Int());
            AddColumn("dbo.Courses", "Student_Id1", c => c.Int());
            AddColumn("dbo.Students", "Course_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Student_Id");
            CreateIndex("dbo.Courses", "Student_Id1");
            CreateIndex("dbo.Students", "Course_Id");
            AddForeignKey("dbo.Courses", "Student_Id", "dbo.Students", "Id");
            AddForeignKey("dbo.Courses", "Student_Id1", "dbo.Students", "Id");
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
            DropForeignKey("dbo.Courses", "Student_Id1", "dbo.Students");
            DropForeignKey("dbo.Courses", "Student_Id", "dbo.Students");
            DropIndex("dbo.Students", new[] { "Course_Id" });
            DropIndex("dbo.Courses", new[] { "Student_Id1" });
            DropIndex("dbo.Courses", new[] { "Student_Id" });
            DropColumn("dbo.Students", "Course_Id");
            DropColumn("dbo.Courses", "Student_Id1");
            DropColumn("dbo.Courses", "Student_Id");
            CreateIndex("dbo.StudentCourses", "Course_Id");
            CreateIndex("dbo.StudentCourses", "Student_Id");
            AddForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
