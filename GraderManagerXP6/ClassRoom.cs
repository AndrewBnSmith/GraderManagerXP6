using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Text.Json.JsonSerializer;

namespace GraderManagerXP6
{
    class ClassRoom
    {
        public Dictionary<string, Student> allStudentsDictionary = new Dictionary<string, Student>();
        public string Name { get; set; }

        public ClassRoom(string className)
        {
            this.Name = className;
        }

        //void ShowAverage()
        //{
          
        //    Console.WriteLine("You are Viewing [ Average Grade }");
        //    Console.WriteLine(allStudentsDictionary.Average());
        //}

        void AddStudentName()
        {
            var studentName = UserInput.StringQuestion("What is the name of the student?");
            var student = new Student(studentName);
            this.allStudentsDictionary.Add(studentName, student);
        }

        public void printMenu()
        {
            bool flag = true;
            while (flag)
            {
                static int acceptChoices()
                {
                    StudentMenu();
                    return UserInput.IntQuestion("");
                }
                int choice = acceptChoices();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(Serialize(allStudentsDictionary.ToList()));
                        break;
                    case 2:
                        AddStudentName();
                        break;
                    case 3:
                       
                        break;
                    case 4:
                        Student student = allStudentsDictionary.Values.First();
                        student.PrintMenu();

                       
                        break;
                    case 5:
                        
                        break;

                    case 6:

                        break;

                    case 7:

                        break;

                    case 8:

                        break;

                    case 9:

                        break;

                    case 10:

                        flag = false; //if (shouldReturnToMainMenu) flag = false;
                        break;



                    default:

                        break;
                }
            }
        }
        public static void StudentMenu()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------");
            Console.WriteLine("|      Grade ManagerXP       |");
            Console.WriteLine("|       Class    Menu        |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. View All Students       |");
            Console.WriteLine("| 2. Add Student             |");
            Console.WriteLine("| 3. Remove Student          |");
            Console.WriteLine("| 4. Student Details         |");
            Console.WriteLine("| 5. Class Average           |");
            Console.WriteLine("| 6. Logout                  |");
            Console.WriteLine("| 7. Class Average           |");
            Console.WriteLine("| 8. Show Top Student        |");
            Console.WriteLine("| 9. Show Worst Student      |");
            Console.WriteLine("| 10. Exit to Main Menu      |");
            Console.WriteLine(" ---------------------------");
        }
       

    }
}



// class room
    // student
        // 