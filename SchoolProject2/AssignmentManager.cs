using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject2.Models;

namespace SchoolProject2
{
    class AssignmentManager
    {
        static public int CreateAssignment(string title,string description, DateTime submission, int oralmark, int totalmark)
        {
            Assignment assignment = new Assignment()
            {
                Title=title,
                Description = description,
                SubmissionDateAndTime = submission,
                OralMark = oralmark,
                TotalMark = totalmark,
            };

            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                db.Assignments.Add(assignment);
                db.SaveChanges();
            }
            return assignment.Id;
        }

        static public List<Assignment> GetAllAssignments()
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                return db.Assignments.ToList();
            }
        }

        static public void UpdateAssignment(int id, string title, string description, DateTime submission, int oralmark, int totalmark)
        {
            using(SchoolProject2Context db=new SchoolProject2Context())
            {
                Assignment AssignmentToUpdate = db.Assignments.Find(id);
                AssignmentToUpdate.Title = title;
                AssignmentToUpdate.Description = description;
                AssignmentToUpdate.OralMark = oralmark;
                AssignmentToUpdate.TotalMark = totalmark;
                db.SaveChanges();
            }
        }

        //DELETE
        static public void DeleteAssignment(int id)
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                Assignment AssignmentToDelete = db.Assignments.Find(id);
                if (AssignmentToDelete == null)
                {
                    return;
                }
                db.Assignments.Remove(AssignmentToDelete);
                db.SaveChanges();
            }
        }

        static public void AssingmnetPerCourse(int id)
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                Assignment assignment = db.Assignments.Find(id);
                List<Course> course = assignment.Courses.ToList();
            }
        }



    }
}
