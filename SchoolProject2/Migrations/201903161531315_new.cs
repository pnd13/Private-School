namespace SchoolProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Trainers", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Courses", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.Trainers", "Course_Id1", "dbo.Courses");
            DropIndex("dbo.Courses", new[] { "Trainer_Id" });
            DropIndex("dbo.Trainers", new[] { "Course_Id" });
            DropIndex("dbo.Trainers", new[] { "Course_Id1" });
            CreateTable(
                "dbo.TrainerCourses",
                c => new
                    {
                        Trainer_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Trainer_Id, t.Course_Id })
                .ForeignKey("dbo.Trainers", t => t.Trainer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Trainer_Id)
                .Index(t => t.Course_Id);
            
            DropColumn("dbo.Courses", "Trainer_Id");
            DropColumn("dbo.Trainers", "Course_Id");
            DropColumn("dbo.Trainers", "Course_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trainers", "Course_Id1", c => c.Int());
            AddColumn("dbo.Trainers", "Course_Id", c => c.Int());
            AddColumn("dbo.Courses", "Trainer_Id", c => c.Int());
            DropForeignKey("dbo.TrainerCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.TrainerCourses", "Trainer_Id", "dbo.Trainers");
            DropIndex("dbo.TrainerCourses", new[] { "Course_Id" });
            DropIndex("dbo.TrainerCourses", new[] { "Trainer_Id" });
            DropTable("dbo.TrainerCourses");
            CreateIndex("dbo.Trainers", "Course_Id1");
            CreateIndex("dbo.Trainers", "Course_Id");
            CreateIndex("dbo.Courses", "Trainer_Id");
            AddForeignKey("dbo.Trainers", "Course_Id1", "dbo.Courses", "Id");
            AddForeignKey("dbo.Courses", "Trainer_Id", "dbo.Trainers", "Id");
            AddForeignKey("dbo.Trainers", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
