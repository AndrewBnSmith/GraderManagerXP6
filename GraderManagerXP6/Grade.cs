using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraderManagerXP6
{
    class Grade : Assignment
    {
        private Dictionary<string, Grade> allStudentGradesDictionary = new Dictionary<string, Grade>();
        public string Name { get; set; }

        public Grade(string grade)
        {
            this.Name = grade;
        }

       void AddGradeMenu()
        {

        }
    }
}
