using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject2
{
    public class AddAssignment
    {
        public static void Add()
        {
            Console.WriteLine("Give a title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Give a description: ");
            string descprition = Console.ReadLine();
            Console.WriteLine("Give submission date and time: ");
            DateTime submission = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give an oral mark: ");
            int oralmark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a total mark: ");
            int totalmark = Convert.ToInt32(Console.ReadLine());

            AssignmentManager.CreateAssignment(title, descprition, submission, oralmark, totalmark);
        }

        public static void View()
        {
            Console.WriteLine("assignments: ");
            foreach (var assignment in AssignmentManager.GetAllAssignments())
            {
                Console.WriteLine(assignment);
            }
        }

        public static void Update()
        {
            Console.WriteLine("Update assignment: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Give a description: ");
            string descprition = Console.ReadLine();
            Console.WriteLine("Give submission date and time: ");
            DateTime submission = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give an oral mark: ");
            int oralmark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a total mark: ");
            int totalmark = Convert.ToInt32(Console.ReadLine());
            AssignmentManager.UpdateAssignment(id, title, descprition, submission, oralmark, totalmark);
        }

        public static void Delete()
        {
            Console.WriteLine("Delete assignment: ");
            int id = Convert.ToInt32(Console.ReadLine());
            AssignmentManager.DeleteAssignment(id);
        }

        public static void CreateAssignmentPerCourse()
        {
            //Console.WriteLine("Assignments: ");
            //foreach (var assignment in AssignmentManager.GetAllAssignments(id))
            //{
            //    Console.WriteLine(assignment);
            //}
            //Console.WriteLine("Assign Course: ");
            //foreach (var course in CourseManager.CreateCourse())

            Console.WriteLine("Give a title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Give a description: ");
            string descprition = Console.ReadLine();
            Console.WriteLine("Give submission date and time: ");
            DateTime submission = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give an oral mark: ");
            int oralmark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a total mark: ");
            int totalmark = Convert.ToInt32(Console.ReadLine());

            AssignmentManager.CreateAssignment(title, descprition, submission, oralmark, totalmark);

        }

        public static void AssignmentPerCourse()
        {
            Console.WriteLine("Find assignment Id");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var course in CourseManager.GetAllCourses())
            {
                Console.WriteLine(course);
            }
            //StudentManager.StudentPerCourse(id);
        }
    }
}
