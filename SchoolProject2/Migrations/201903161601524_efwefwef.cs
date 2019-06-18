namespace SchoolProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class efwefwef : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Assignment_Id", "dbo.Assignments");
            DropIndex("dbo.Courses", new[] { "Assignment_Id" });
            CreateTable(
                "dbo.CourseAssignments",
                c => new
                    {
                        Course_Id = c.Int(nullable: false),
                        Assignment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_Id, t.Assignment_Id })
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .ForeignKey("dbo.Assignments", t => t.Assignment_Id, cascadeDelete: true)
                .Index(t => t.Course_Id)
                .Index(t => t.Assignment_Id);
            
            DropColumn("dbo.Courses", "Assignment_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Assignment_Id", c => c.Int());
            DropForeignKey("dbo.CourseAssignments", "Assignment_Id", "dbo.Assignments");
            DropForeignKey("dbo.CourseAssignments", "Course_Id", "dbo.Courses");
            DropIndex("dbo.CourseAssignments", new[] { "Assignment_Id" });
            DropIndex("dbo.CourseAssignments", new[] { "Course_Id" });
            DropTable("dbo.CourseAssignments");
            CreateIndex("dbo.Courses", "Assignment_Id");
            AddForeignKey("dbo.Courses", "Assignment_Id", "dbo.Assignments", "Id");
        }
    }
}
