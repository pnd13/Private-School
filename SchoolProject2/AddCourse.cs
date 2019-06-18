using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject2
{
    public class AddCourse
    {
        public static void Add()
        {
            Console.WriteLine("Give a title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Give a stream: ");
            string stream = Console.ReadLine();
            Console.WriteLine("Give a type: ");
            string type = Console.ReadLine();
            Console.WriteLine("Give a start date: ");
            DateTime startdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give an end date: ");
            DateTime enddate = Convert.ToDateTime(Console.ReadLine());

            CourseManager.CreateCourse(title, stream, type, startdate, enddate);
        }

        public static void View()
        {
            Console.WriteLine("Courses: ");
            foreach (var course in CourseManager.GetAllCourses())
            {
                Console.WriteLine(course);
            }
        }

        public static void Update()
        {
            Console.WriteLine("Update course: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Give a stream: ");
            string stream = Console.ReadLine();
            Console.WriteLine("Give a type: ");
            string type = Console.ReadLine();
            Console.WriteLine("Give a start date: ");
            DateTime startdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give an end date: ");
            DateTime enddate = Convert.ToDateTime(Console.ReadLine());
            CourseManager.UpdateCourse(id,title, stream, type, startdate, enddate);
        }

        public static void Delete()
        {
            Console.WriteLine("Delete course: ");
            int id = Convert.ToInt32(Console.ReadLine());
            CourseManager.DeleteCourse(id);
        }
    }
}
