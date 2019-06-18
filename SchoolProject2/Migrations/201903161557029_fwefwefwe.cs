namespace SchoolProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fwefwefwe : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Assignments", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.StudentAssignments", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentAssignments", "Assignment_Id", "dbo.Assignments");
            DropForeignKey("dbo.TrainerAssignments", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.TrainerAssignments", "Assignment_Id", "dbo.Assignments");
            DropForeignKey("dbo.TrainerCourses", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.TrainerCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.TrainerStudents", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.TrainerStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Assignments", "Course_Id1", "dbo.Courses");
            DropForeignKey("dbo.Courses", "Assignment_Id", "dbo.Assignments");
            DropIndex("dbo.Assignments", new[] { "Course_Id" });
            DropIndex("dbo.Assignments", new[] { "Course_Id1" });
            DropIndex("dbo.Courses", new[] { "Assignment_Id" });
            DropIndex("dbo.StudentAssignments", new[] { "Student_Id" });
            DropIndex("dbo.StudentAssignments", new[] { "Assignment_Id" });
            DropIndex("dbo.TrainerAssignments", new[] { "Trainer_Id" });
            DropIndex("dbo.TrainerAssignments", new[] { "Assignment_Id" });
            DropIndex("dbo.TrainerCourses", new[] { "Trainer_Id" });
            DropIndex("dbo.TrainerCourses", new[] { "Course_Id" });
            DropIndex("dbo.TrainerStudents", new[] { "Trainer_Id" });
            DropIndex("dbo.TrainerStudents", new[] { "Student_Id" });
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
            
            AddColumn("dbo.Courses", "Trainer_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Trainer_Id");
            AddForeignKey("dbo.Courses", "Trainer_Id", "dbo.Trainers", "Id");
            DropColumn("dbo.Assignments", "Course_Id");
            DropColumn("dbo.Assignments", "Course_Id1");
            DropColumn("dbo.Courses", "Assignment_Id");
            DropTable("dbo.StudentAssignments");
            DropTable("dbo.TrainerAssignments");
            DropTable("dbo.TrainerCourses");
            DropTable("dbo.TrainerStudents");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TrainerStudents",
                c => new
                    {
                        Trainer_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Trainer_Id, t.Student_Id });
            
            CreateTable(
                "dbo.TrainerCourses",
                c => new
                    {
                        Trainer_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Trainer_Id, t.Course_Id });
            
            CreateTable(
                "dbo.TrainerAssignments",
                c => new
                    {
                        Trainer_Id = c.Int(nullable: false),
                        Assignment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Trainer_Id, t.Assignment_Id });
            
            CreateTable(
                "dbo.StudentAssignments",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Assignment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Assignment_Id });
            
            AddColumn("dbo.Courses", "Assignment_Id", c => c.Int());
            AddColumn("dbo.Assignments", "Course_Id1", c => c.Int());
            AddColumn("dbo.Assignments", "Course_Id", c => c.Int());
            DropForeignKey("dbo.Courses", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.CourseAssignments", "Assignment_Id", "dbo.Assignments");
            DropForeignKey("dbo.CourseAssignments", "Course_Id", "dbo.Courses");
            DropIndex("dbo.CourseAssignments", new[] { "Assignment_Id" });
            DropIndex("dbo.CourseAssignments", new[] { "Course_Id" });
            DropIndex("dbo.Courses", new[] { "Trainer_Id" });
            DropColumn("dbo.Courses", "Trainer_Id");
            DropTable("dbo.CourseAssignments");
            CreateIndex("dbo.TrainerStudents", "Student_Id");
            CreateIndex("dbo.TrainerStudents", "Trainer_Id");
            CreateIndex("dbo.TrainerCourses", "Course_Id");
            CreateIndex("dbo.TrainerCourses", "Trainer_Id");
            CreateIndex("dbo.TrainerAssignments", "Assignment_Id");
            CreateIndex("dbo.TrainerAssignments", "Trainer_Id");
            CreateIndex("dbo.StudentAssignments", "Assignment_Id");
            CreateIndex("dbo.StudentAssignments", "Student_Id");
            CreateIndex("dbo.Courses", "Assignment_Id");
            CreateIndex("dbo.Assignments", "Course_Id1");
            CreateIndex("dbo.Assignments", "Course_Id");
            AddForeignKey("dbo.Courses", "Assignment_Id", "dbo.Assignments", "Id");
            AddForeignKey("dbo.Assignments", "Course_Id1", "dbo.Courses", "Id");
            AddForeignKey("dbo.TrainerStudents", "Student_Id", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TrainerStudents", "Trainer_Id", "dbo.Trainers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TrainerCourses", "Course_Id", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TrainerCourses", "Trainer_Id", "dbo.Trainers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TrainerAssignments", "Assignment_Id", "dbo.Assignments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TrainerAssignments", "Trainer_Id", "dbo.Trainers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentAssignments", "Assignment_Id", "dbo.Assignments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentAssignments", "Student_Id", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Assignments", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
