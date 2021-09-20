using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraderManagerXP6
{
    public class Assignment : Student
    {
        private Dictionary<string, Grade> allStudentGradesDictionary = new Dictionary<string, Grade>();
        public string Name { get; set; }

        public Assignment(string assignment)
        {
            this.Name = assignment;
        }

        void AddGrade(Grade test)
        {
            this.allStudentGradesDictionary.Add(test.Name, test);
        }

    }
}
