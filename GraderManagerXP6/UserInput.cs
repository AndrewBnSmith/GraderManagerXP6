using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraderManagerXP6
{
    class UserInput
    {
        static public string StringQuestion(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        static public int IntQuestion(string question)
        {
            System.Console.Write(question);
            bool state = int.TryParse(System.Console.ReadLine(), out int result);
            while (!state)
            {
                System.Console.Write("Invalid input. Please try again: ");
                state = int.TryParse(System.Console.ReadLine(), out result);
            }

            return result;

        }
    }
}
