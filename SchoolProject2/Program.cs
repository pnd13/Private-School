using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu d = new Menu();

                while (true)
                {
                    Menu.Roles();
                    string input = Console.ReadLine();
                    Console.Clear();
                    switch (input)
                    {
                        case "0":
                            {
                                Environment.Exit(0);
                                break;
                            }
                        case "1":
                            {
                                Menu.CrudHeadMaster();
                                string input2 = Console.ReadLine();
                                Console.Clear();
                                switch (input2)
                                {
                                    case "1":
                                        {
                                            Menu.StudentCRUD();
                                            break;
                                        }
                                    case "2":
                                        {
                                            Menu.CourseCRUD();
                                            break;
                                        }
                                    case "3":
                                        {
                                            Menu.AssignmentCRUD();
                                            break;
                                        }
                                    case "4":
                                        {
                                            Menu.TrainerCRUD();
                                            break;
                                        }
                                }                           
                            break;
                            }
                        case "2":
                            {
                                Menu.Trainer();
                                break;
                            }
                        //case "3":
                        //    {
                        //        Menu.Student();
                        //        break;
                        //    }

                    }

                }
                

                Console.WriteLine("0. Exit");
                Console.WriteLine("11. Enter password username:");
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
                Console.WriteLine("13.View all the courses, the teachers has enrolled");
                Console.WriteLine("14. Update Student");
                Console.WriteLine("15. Update Trainer");
                Console.WriteLine("16. Update Course");
                Console.WriteLine("17. Update Assignment");
                Console.WriteLine("18. Create Assignment per Course");
                Console.WriteLine("19.  Student Per Course");
                Console.WriteLine("20.  Trainer Per Course");
                Console.WriteLine("21.  Assignment Per Course");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        {
                            //Console.Write("Give student First Name: ");
                            //string firstname = Console.ReadLine();
                            //Console.WriteLine("Give student Last Name: ");
                            //string lastname = Console.ReadLine();
                            //Console.WriteLine("Give student Date of birth: ");
                            //DateTime dateofbirth = Convert.ToDateTime(Console.ReadLine());
                            //Console.WriteLine("Give student Tuition fees: ");
                            //decimal tuitionfees = Convert.ToDecimal(Console.ReadLine());

                            //StudentManager.CreateStudent(firstname, lastname, dateofbirth, tuitionfees);
                            AddStudent.Add();
                            break;
                        }
                    case "2":
                        {
                            //Console.WriteLine("Give trainer First Name: ");
                            //string firstname = Console.ReadLine();
                            //Console.WriteLine("Give trainer Last Name: ");
                            //string lastname = Console.ReadLine();
                            //Console.WriteLine("Give trainer Subject");
                            //string subject = Console.ReadLine();

                            //TrainerManager.CreateTrainer(firstname, lastname, subject);
                            AddTrainer.Add();
                            break;
                        }
                    case "3":
                        {
                            //Console.WriteLine("Give a title: ");
                            //string title = Console.ReadLine();
                            //Console.WriteLine("Give a description: ");
                            //string descprition = Console.ReadLine();
                            //Console.WriteLine("Give submission date and time: ");
                            //DateTime submission = Convert.ToDateTime(Console.ReadLine());
                            //Console.WriteLine("Give an oral mark: ");
                            //int oralmark = Convert.ToInt32(Console.ReadLine());
                            //Console.WriteLine("Give a total mark: ");
                            //int totalmark = Convert.ToInt32(Console.ReadLine());

                            //AssignmentManager.CreateAssignment(title,descprition, submission, oralmark, totalmark);
                            AddAssignment.Add();
                            break;
                        }
                    case "4":
                        {
                            //Console.WriteLine("Give a title: ");
                            //string title = Console.ReadLine();
                            //Console.WriteLine("Give a stream: ");
                            //string stream = Console.ReadLine();
                            //Console.WriteLine("Give a type: ");
                            //string type = Console.ReadLine();
                            //Console.WriteLine("Give a start date: ");
                            //DateTime startdate = Convert.ToDateTime(Console.ReadLine());
                            //Console.WriteLine("Give an end date: ");
                            //DateTime enddate = Convert.ToDateTime(Console.ReadLine());

                            //CourseManager.CreateCourse(title,stream, type, startdate, enddate);
                            AddCourse.Add();
                            break;
                        }
                    case "5":
                        {
                            //Console.WriteLine("Students: ");
                            //foreach (var student in StudentManager.GetAllStudents())
                            //{
                            //    Console.WriteLine(student);
                            //}
                            AddStudent.View();
                            break;
                        }
                    case "6":
                        {
                            //Console.WriteLine("Courses: ");
                            //foreach (var course in CourseManager.GetAllCourses())
                            //{
                            //    Console.WriteLine(course);
                            //}
                            AddCourse.View();
                            break;
                        }
                    case "7":
                        {
                            //Console.WriteLine("assignments: ");
                            //foreach (var assignment in AssignmentManager.GetAllAssignments())
                            //{
                            //    Console.WriteLine(assignment);
                            //}
                            AddAssignment.View();
                            break;
                        }
                    case "8":
                        {
                            //Console.WriteLine("trainers: ");
                            //foreach (var trainer in TrainerManager.GetAllTrainers())
                            //{
                            //    Console.WriteLine(trainer);
                            //}
                            AddTrainer.View();
                            break;
                        }
                    case "9":
                        {
                            //// DEN LEITOURGEI TO DELETE
                            //Console.WriteLine("Delete assignment: ");
                            //string name = Console.ReadLine();
                            //AssignmentManager.DeleteAssignment(name);
                            AddAssignment.Delete();
                            break;
                        }
                    case "10":
                        {
                            
                            //Console.WriteLine("Delete trainer: ");
                            //int id = Convert.ToInt32(Console.ReadLine());
                            //TrainerManager.DeleteTrainer(id);
                            AddTrainer.Delete();
                            break;
                        }
                    case "11":
                        {
                            //// DEN LEITOURGEI TO DELETE
                            //Console.WriteLine("Delete student: ");
                            //string name = Console.ReadLine();
                            //StudentManager.DeleteStudent(name);
                            AddStudent.Delete();
                            break;
                        }
                    case "12":
                        {
                            //Console.WriteLine("Delete course: ");
                            //string name = Console.ReadLine();
                            //CourseManager.DeleteCourse(name);
                            AddCourse.Delete();
                            break;
                        }
                    //case "13":
                    //    {
                    //        Console.WriteLine("Print all teachers with theirs courses");
                    //        foreach (var x in TrainerManager.Include("Course")
                    //        {
                    //            Console.WriteLine(x);
                    //        }
                    //        break;
                    //    }
                    case "14":
                        {
                            AddStudent.Update();
                            break;
                        }
                    case "15":
                        {
                            AddTrainer.Update();
                            break;
                        }
                    case "16":
                        {
                            AddCourse.Update();
                            break;
                        }
                    case "17":
                        {
                            AddAssignment.Update();
                            break;
                        }
                    case "18":
                        {
                            //AddAssignment.AssignmentPerCourse();
                            break;
                        }
                    case "19":
                        {
                            AddStudent.StudentPerCourse();
                            break;
                        }
                    case "20":
                        {
                            AddTrainer.TrainerPerCourse();
                            break;
                        }
                    case "21":
                        {
                            AddAssignment.AssignmentPerCourse();
                            break;
                        }
                    default:
                        break;
                }
            }
            Console.ReadKey();

        }
    }
    }

