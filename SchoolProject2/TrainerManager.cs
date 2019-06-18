using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject2.Models;

namespace SchoolProject2
{
    class TrainerManager
    {
        static public int CreateTrainer(string firstname, string lastname, string subject)
        {
            Trainer trainer = new Trainer()
            {
                FirstName = firstname,
                LastName = lastname,
                Subject = subject,
            };

            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                db.Trainers.Add(trainer);
                db.SaveChanges();
            }
            return trainer.Id;
        }

        static public List<Trainer> GetAllTrainers()
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                return db.Trainers.ToList();
            }
        }

        static public void UpdateTrainer(int id, string firstname, string lastname, string subject)
        {
            using( SchoolProject2Context db=new SchoolProject2Context())
            {
                Trainer TrainerToUpdate = db.Trainers.Find(id);
                TrainerToUpdate.FirstName = firstname;
                TrainerToUpdate.LastName = lastname;
                TrainerToUpdate.Subject = subject;
                db.SaveChanges();
            }
        }

        //DELETE
        static public void DeleteTrainer(int id)
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                Trainer TrainerToDelete = db.Trainers.Find(id);
                if (TrainerToDelete == null)
                {
                    return;
                }
                db.Trainers.Remove(TrainerToDelete);
                db.SaveChanges();
            }
        }

        static public void TrainerPerCourse(int id)
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                Trainer trainer = db.Trainers.Find(id);
                List<Course> course = trainer.Courses.ToList();
            }
        }
    }
}
