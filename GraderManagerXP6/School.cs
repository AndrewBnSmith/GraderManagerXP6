using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraderManagerXP6
{
    public class School 
    {
        public Dictionary<string, ClassRoom> allClassRoomsDictionary = new Dictionary<string, ClassRoom>();
        public string Name { get; set; }

        public School(string school)
        {
            this.Name = school;
        }
        
        public void AddClassRoom(ClassRoom CSharp)
        {
            this.allClassRoomsDictionary.Add(CSharp.Name, CSharp);
        }

       
           


        
    }
}
