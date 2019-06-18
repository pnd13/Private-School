using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject2
{
    public class AddTrainer
    {
        public static void Add()
        {
            Console.WriteLine("Give trainer First Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Give trainer Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Give trainer Subject");
            string subject = Console.ReadLine();

            TrainerManager.CreateTrainer(firstname, lastname, subject);
        }

        public static void View()
        {
            Console.WriteLine("trainers: ");
            foreach (var trainer in TrainerManager.GetAllTrainers())
            {
                Console.WriteLine(trainer);
            }
        }

        public static void Update()
        {
            Console.WriteLine("Update trainer: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give trainer First Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Give trainer Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Give trainer Subject");
            string subject = Console.ReadLine();
            TrainerManager.UpdateTrainer(id, firstname, lastname, subject);
        }


        public static void Delete()
        {
            
            Console.WriteLine("Delete trainer: ");
            int id = Convert.ToInt32(Console.ReadLine());
            TrainerManager.DeleteTrainer(id);
        }


        public static void TrainerPerCourse()
        {
            Console.WriteLine("Find trainer Id");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var course in CourseManager.GetAllCourses())
            {
                Console.WriteLine(course);
            }
            //StudentManager.StudentPerCourse(id);
        }

    }
}
