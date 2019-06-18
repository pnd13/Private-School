namespace SchoolProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        SubmissionDateAndTime = c.DateTime(nullable: false),
                        OralMark = c.Int(nullable: false),
                        TotalMark = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Stream = c.String(),
                        Type = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Trainer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trainers", t => t.Trainer_Id)
                .Index(t => t.Trainer_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        TuitionFees = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Subject = c.String(),
                        Course_Id = c.Int(),
                        Course_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id1)
                .Index(t => t.Course_Id)
                .Index(t => t.Course_Id1);
            
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
            
            CreateTable(
                "dbo.StudentAssignments",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Assignment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Assignment_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Assignments", t => t.Assignment_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Assignment_Id);
            
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
            
            CreateTable(
                "dbo.TrainerAssignments",
                c => new
                    {
                        Trainer_Id = c.Int(nullable: false),
                        Assignment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Trainer_Id, t.Assignment_Id })
                .ForeignKey("dbo.Trainers", t => t.Trainer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Assignments", t => t.Assignment_Id, cascadeDelete: true)
                .Index(t => t.Trainer_Id)
                .Index(t => t.Assignment_Id);
            
            CreateTable(
                "dbo.TrainerStudents",
                c => new
                    {
                        Trainer_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Trainer_Id, t.Student_Id })
                .ForeignKey("dbo.Trainers", t => t.Trainer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Trainer_Id)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainers", "Course_Id1", "dbo.Courses");
            DropForeignKey("dbo.TrainerStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.TrainerStudents", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.Courses", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.Trainers", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.TrainerAssignments", "Assignment_Id", "dbo.Assignments");
            DropForeignKey("dbo.TrainerAssignments", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentAssignments", "Assignment_Id", "dbo.Assignments");
            DropForeignKey("dbo.StudentAssignments", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.CourseAssignments", "Assignment_Id", "dbo.Assignments");
            DropForeignKey("dbo.CourseAssignments", "Course_Id", "dbo.Courses");
            DropIndex("dbo.TrainerStudents", new[] { "Student_Id" });
            DropIndex("dbo.TrainerStudents", new[] { "Trainer_Id" });
            DropIndex("dbo.TrainerAssignments", new[] { "Assignment_Id" });
            DropIndex("dbo.TrainerAssignments", new[] { "Trainer_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Course_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            DropIndex("dbo.StudentAssignments", new[] { "Assignment_Id" });
            DropIndex("dbo.StudentAssignments", new[] { "Student_Id" });
            DropIndex("dbo.CourseAssignments", new[] { "Assignment_Id" });
            DropIndex("dbo.CourseAssignments", new[] { "Course_Id" });
            DropIndex("dbo.Trainers", new[] { "Course_Id1" });
            DropIndex("dbo.Trainers", new[] { "Course_Id" });
            DropIndex("dbo.Courses", new[] { "Trainer_Id" });
            DropTable("dbo.TrainerStudents");
            DropTable("dbo.TrainerAssignments");
            DropTable("dbo.StudentCourses");
            DropTable("dbo.StudentAssignments");
            DropTable("dbo.CourseAssignments");
            DropTable("dbo.Trainers");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
            DropTable("dbo.Assignments");
        }
    }
}
