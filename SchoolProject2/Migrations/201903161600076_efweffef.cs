namespace SchoolProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class efweffef : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CourseAssignments", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.CourseAssignments", "Assignment_Id", "dbo.Assignments");
            DropIndex("dbo.CourseAssignments", new[] { "Course_Id" });
            DropIndex("dbo.CourseAssignments", new[] { "Assignment_Id" });
            AddColumn("dbo.Courses", "Assignment_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Assignment_Id");
            AddForeignKey("dbo.Courses", "Assignment_Id", "dbo.Assignments", "Id");
            DropTable("dbo.CourseAssignments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CourseAssignments",
                c => new
                    {
                        Course_Id = c.Int(nullable: false),
                        Assignment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_Id, t.Assignment_Id });
            
            DropForeignKey("dbo.Courses", "Assignment_Id", "dbo.Assignments");
            DropIndex("dbo.Courses", new[] { "Assignment_Id" });
            DropColumn("dbo.Courses", "Assignment_Id");
            CreateIndex("dbo.CourseAssignments", "Assignment_Id");
            CreateIndex("dbo.CourseAssignments", "Course_Id");
            AddForeignKey("dbo.CourseAssignments", "Assignment_Id", "dbo.Assignments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CourseAssignments", "Course_Id", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}
