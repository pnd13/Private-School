using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject2
{
    public class Menu
    {
        public static void Roles()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Head Master");
            Console.WriteLine("2. Trainer");
            Console.WriteLine("3. Student");        
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create new Student");
            Console.WriteLine("2. Add new Trainer");
            Console.WriteLine("3. Add new Assignment");
            Console.WriteLine("4. Add new Course");
            Console.WriteLine("5. View all Students");
            Console.WriteLine("6. View all Courses");
            Console.WriteLine("7. View all assignments");
            Console.WriteLine("8. View all trainers");
            Console.WriteLine("9. Delete an assignment");
            Console.WriteLine("10. Delete a trainer");
            Console.WriteLine("11. Delete a student");
            Console.WriteLine("12. Delete a course");
        }

        public static void CrudHeadMaster()
        {
            Console.WriteLine("1. CRUD on Students");
            Console.WriteLine("2. CRUD on Courses");
            Console.WriteLine("3. CRUD on Assignments");
            Console.WriteLine("4. CRUD on Trainers");
        }
        public static void HeadMaster()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("1. Create new Student:");
                        AddStudent.Add();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("2. View All Students:");
                        AddStudent.View();
                        break;
                    }
                //case "3":
                //    {
                //        Console.WriteLine("3. Update a Student: ");
                //        AddStudent.Update();
                //        break;
                //    }
                case "4":
                    {
                        Console.WriteLine("4. Delete a Student:");
                        AddStudent.Delete();                        
                        break;
                    }
                default:
                    DisplayMenu();

                    break;
            }
            AddCourse.Add();
            AddCourse.View();
            AddCourse.Delete();
            Console.WriteLine("CRUD on Students");
            AddCourse.Add();
            AddCourse.View();
            AddCourse.Delete();
            Console.WriteLine("CRUD on Assignments");
            AddCourse.Add();
            AddCourse.View();
            AddCourse.Delete();
            Console.WriteLine("CRUD on Trainers");
            AddCourse.Add();
            AddCourse.View();
            AddCourse.Delete();
        }

        public static void Trainer()
        {
            Console.WriteLine("1. View Assignment per Course by id:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddAssignment.AssignmentPerCourse();
                    break;

            }
        }


        public static void AssignmentCRUD()
        {
            Console.WriteLine("1. Add new Assignment");
            Console.WriteLine("2. View all Assignments:");
            Console.WriteLine("3. Update an Assignment by id: ");
            Console.WriteLine("4. Delete an Assignment:");
            //Console.WriteLine("5. View Assignment per Course:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddAssignment.Add();
                    break;
                case "2":
                    AddAssignment.View();
                    break;
                case "3":
                    AddAssignment.Update();
                    break;
                case "4":
                    AddAssignment.Delete();
                    break;
                //case "5":
                //    AddAssignment.AssignmentPerCourse();
                //    break;
            }
        }
        public static void CourseCRUD()
        {
            Console.WriteLine("1. Add new Course");
            Console.WriteLine("2. View all Courses:");
            Console.WriteLine("3. Update a Course: ");
            Console.WriteLine("4. Delete a Course:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddCourse.Add();
                    break;
                case "2":
                    AddCourse.View();
                    break;
                case "3":
                    AddCourse.Update();
                    break;
                case "4":
                    AddCourse.Delete();
                    break;
            }
        }

        public static void TrainerCRUD()
        {
            Console.WriteLine("1. Create new Trainer:");
            Console.WriteLine("2. View all Trainers:");
            Console.WriteLine("3. Update a Trainer: ");
            Console.WriteLine("4. Delete a Trainer:");
            Console.WriteLine("5. View Trainer per Course:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddTrainer.Add();
                    break;
                case "2":
                    AddTrainer.View();
                    break;
                case "3":
                    AddTrainer.Update();
                    break;
                case "4":
                    AddTrainer.Delete();
                    break;
                case "5":
                    AddTrainer.TrainerPerCourse();
                    break;

            }

        }

        public static void StudentCRUD()
        {
            Console.WriteLine("1. Create new Student:");
            Console.WriteLine("2. View All Students:");
            Console.WriteLine("3. Update a Student: ");
            Console.WriteLine("4. Delete a Student:");
            Console.WriteLine("5. View Student Per Course");
            Console.WriteLine("6. Back to Head Master Menu");
            string input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                case "1":
                    AddStudent.Add();
                    break;
                case "2":
                    AddStudent.View();
                    break;
                case "3":
                    AddStudent.Update();
                    break;
                case "4":
                    AddStudent.Delete();
                    break;
                case "5":
                    AddStudent.StudentPerCourse();
                    break;
                case "6":
                    CrudHeadMaster();
                    break;
            }

        }

    }
}
