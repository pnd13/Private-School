using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject2.Models;

namespace SchoolProject2
{
    class StudentManager
    {
        //CREATE
        static public int CreateStudent(string firstname, string lastname, DateTime date_of_birth, decimal tuition_fees)
        {
            Student student = new Student()
            {
                FirstName = firstname,
                LastName = lastname,
                DateOfBirth = date_of_birth,
                TuitionFees = tuition_fees

            };

            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
            return student.Id;
        }

        // READ
        static public List<Student> GetAllStudents()
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                return db.Students.ToList();
            }
        }

        //UPDATE   
        static public void UpdateStudent(int id, string firstname, string lastname, DateTime date_of_birth, decimal tuition_fees)
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                Student StudentToUpdate = db.Students.Find(id);
                StudentToUpdate.FirstName = firstname;
                StudentToUpdate.LastName = lastname;
                StudentToUpdate.DateOfBirth = date_of_birth;
                StudentToUpdate.TuitionFees = tuition_fees;
                db.SaveChanges();
            }
        }

        //DELETE
        static public void DeleteStudent(int id)
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                Student StudentToDelete = db.Students.Find(id);
                if (StudentToDelete == null)
                {
                    return;                   
                }
                db.Students.Remove(StudentToDelete);
                db.SaveChanges();
            }
        }

        //STUDENT PER COURSE UPDATED
        static public void StudentPerCourse(int id)
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                Student student = db.Students.Find(id);
                List<Course> course = student.Courses.ToList();
            }
        }

        public static void CreateAccount(int Id, string Username, string Password)
        {
            using (SchoolProject2Context db = new SchoolProject2Context())
            {
                Student student = db.Students.Find(Id);
                if (student == null)
                {
                    Console.WriteLine("Nothing.");
                    return;
                }
                student.Username = Username;
                student.Password = Password;
                db.SaveChanges();
            }
        }

       
       
    }
}
