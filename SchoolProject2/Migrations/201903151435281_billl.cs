namespace SchoolProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class billl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Courses", "Student_Id1", "dbo.Students");
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Courses", new[] { "Student_Id" });
            DropIndex("dbo.Courses", new[] { "Student_Id1" });
            DropIndex("dbo.Students", new[] { "Course_Id" });
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
            
            DropColumn("dbo.Courses", "Student_Id");
            DropColumn("dbo.Courses", "Student_Id1");
            DropColumn("dbo.Students", "Course_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Course_Id", c => c.Int());
            AddColumn("dbo.Courses", "Student_Id1", c => c.Int());
            AddColumn("dbo.Courses", "Student_Id", c => c.Int());
            DropForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentCourses", new[] { "Course_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            DropTable("dbo.StudentCourses");
            CreateIndex("dbo.Students", "Course_Id");
            CreateIndex("dbo.Courses", "Student_Id1");
            CreateIndex("dbo.Courses", "Student_Id");
            AddForeignKey("dbo.Students", "Course_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.Courses", "Student_Id1", "dbo.Students", "Id");
            AddForeignKey("dbo.Courses", "Student_Id", "dbo.Students", "Id");
        }
    }
}
