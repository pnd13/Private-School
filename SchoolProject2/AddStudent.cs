using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject2.Models;

namespace SchoolProject2
{
    public class AddStudent
    {
        public static void Add()
        {
            Console.Write("Give student First Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Give student Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Give student Date of birth: ");
            DateTime dateofbirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give student Tuition fees: ");
            decimal tuitionfees = Convert.ToDecimal(Console.ReadLine());

            StudentManager.CreateStudent(firstname, lastname, dateofbirth, tuitionfees);
        }

        public static void View()
        {
            Console.WriteLine("Students: ");
            foreach (var student in StudentManager.GetAllStudents())
            {
                Console.WriteLine(student);
            }
        }

        public static void Update()
        {
            Console.WriteLine("Update student");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give student First Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Give student Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Give student Date of birth: ");
            DateTime dateofbirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give student Tuition fees: ");
            decimal tuitionfees = Convert.ToDecimal(Console.ReadLine());
            StudentManager.UpdateStudent(id,firstname, lastname, dateofbirth, tuitionfees);
        }

        public static void Delete()
        {
            Console.WriteLine("Delete student: ");
            int id =Convert.ToInt32( Console.ReadLine());
            StudentManager.DeleteStudent(id);
        }




        public static void StudentPerCourse()
        {
            Console.WriteLine("Find student Id");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var course in CourseManager.GetAllCourses())
            {
                Console.WriteLine(course);
            }
            //StudentManager.StudentPerCourse(id);
        }

        public static void StudentAccount()
        {
            Console.WriteLine("Username: ");
            string password = Console.ReadLine();
            string hashed = SecurePasswordHasher.Hash(password);
        }

        public static Student FindPassword(string Username)
        {
            using(SchoolProject2Context db=new SchoolProject2Context())
            {
                var query = db.Students.Where(x => x.Username == Username).FirstOrDefault < Student>();
                return query;
            }
        }



    }
}
