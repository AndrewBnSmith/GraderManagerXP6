using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraderManagerXP6
{
    public class Student 
    {
        private Dictionary<string, Assignment> allStudentAssignmentsDictionary = new Dictionary<string, Assignment>();
        public string Name { get; set; }

        public Student(string student)
        {
            this.Name = student;
        }

        void AddStudent(Assignment Lab2)
        {
            this.allStudentAssignmentsDictionary.Add(Lab2.Name, Lab2);
        }

        public static void StudentMenu()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------");
            Console.WriteLine("|      Grade ManagerXP       |");
            Console.WriteLine("|       Student  Menu        |");
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
            Console.WriteLine("| 9. Exit to Login           |");
            Console.WriteLine(" ---------------------------");
        }

        public static void EditStudentMenu()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------");
            Console.WriteLine("|      Grade ManagerXP       |");
            Console.WriteLine("|     Edit Student Menu      |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. Show Student Details    |");
            Console.WriteLine("| 2. Assign Work             |");
            Console.WriteLine("| 3. Delete Work             |");
            Console.WriteLine("| 4. Show All Assignments    |");
            Console.WriteLine("| 5. Show Best Grade         |");
            Console.WriteLine("| 6. Show Worst Grade        |");
            Console.WriteLine("| 9. Exit to Class Menu      |");
            Console.WriteLine("| 9. Exit to Login           |");
            Console.WriteLine(" ---------------------------");
        }

    }
}
