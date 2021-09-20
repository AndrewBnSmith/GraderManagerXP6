using System;

namespace GraderManagerXP6
{
    class StartofApp
    {
        static void Main(string[] args)
        {

           




            static int acceptChoices()
            {
                return UserInput.IntQuestion("\n1. Add Class Room\n2. View All Classrooms\n3. Remove Classroom\n4. Edit Classroom\n5. Exit App\nPlease enter a Choice: ");
            }

            bool flag = true;
            while (flag)
            {

                int choice = acceptChoices();
                switch (choice)
                {
                    case 1:
                        
                        break;
                    case 2:
                        //display();
                        break;
                    case 3:
                       // Pay();
                        break;
                    case 4:
                       // RaiseComplaint();
                        break;
                    case 5:
                        //await showPerformance();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }




        }
    }
}
