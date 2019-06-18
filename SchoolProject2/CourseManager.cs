using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject2.Models;

namespace SchoolProject2
{
    class CourseManager
    {
        static public int CreateCourse(string title,string stream, string type, DateTime startdate, DateTime enddate)
        {
            Course course = new Course()
            {
                Title=title,
                Stream = stream,
                Type = type,
                StartDate = startdate,
                EndDate = enddate
            };

            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                db.Courses.Add(course);
                db.SaveChanges();
            }
            return course.Id;
        }

        // READ

        static public List<Course> GetAllCourses()
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                return db.Courses.ToList();
            }
        }

        static public void UpdateCourse(int id, string title, string stream, string type, DateTime startdate, DateTime enddate)
        {
            using (SchoolProject2Context db=new SchoolProject2Context())
            {
                Course CourseToUpdate = db.Courses.Find(id);
                CourseToUpdate.Title = title;
                CourseToUpdate.Stream = stream;
                CourseToUpdate.Type = type;
                CourseToUpdate.StartDate = startdate;
                CourseToUpdate.EndDate = enddate;
                db.SaveChanges();
            }
        }

        //DELETE
        static public void DeleteCourse(int id)
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                Course CourseToDelete = db.Courses.Find(id);
                if (CourseToDelete == null)
                {
                    return;
                }
                db.Courses.Remove(CourseToDelete);
                db.SaveChanges();
            }
        }



        //UPDATED STUDENT PER COURSE

        static public List<Course> CourseById()
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {

                return db.Courses.ToList();
            }
        }

    }
}
