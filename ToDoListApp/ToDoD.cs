using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    class ToDoD : Program
    {
        public static void ToDo4()
        {
        ToDoDStart:
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen To Do -- D. Edit or Delete the To Do (E/D)");
            string toDoD = Console.ReadLine().ToUpper();
            if (toDoD == "E")
            {
                Console.WriteLine("You have chosen to edit");
                Console.WriteLine("What would you like to change it to");
                string changesToD = Console.ReadLine();
                List1.toDoChosen[3] = changesToD;
                Console.WriteLine("You have succesfully changed the value of To Do D to " + changesToD);
                ToDos.Main1();
            }
            else if (toDoD == "D")
            {
                Console.WriteLine("Please confirm that you would like to delete this to do by typing \"yes\"");
                string deleteD = Console.ReadLine();
                if (deleteD == "yes")
                {
                    List1.toDoChosen[3] = "";
                    ToDos.Main1();
                }
                else
                {
                    ToDos.Main1();
                }
            }
            else
            {
                while (toDoD != "E" || toDoD != "D")
                {
                    goto ToDoDStart;
                }
            }
            Console.ReadKey();
        }
    }
}
