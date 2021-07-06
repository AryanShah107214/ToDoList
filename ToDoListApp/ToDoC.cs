using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    class ToDoC : Program
    {
        public static void ToDo3()
        {
        ToDoCStart:
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen To Do -- C. Edit or Delete the To Do (E/D)");
            string toDoC = Console.ReadLine().ToUpper();
            if (toDoC == "E")
            {
                Console.WriteLine("You have chosen to edit");
                Console.WriteLine("What would you like to change it to");
                string changesToC = Console.ReadLine();
                List1.toDoChosen[2] = changesToC;
                Console.WriteLine("You have succesfully changed the value of To Do C to " + changesToC);
                ToDos.Main1();
            }
            else if (toDoC == "D")
            {
                Console.WriteLine("Please confirm that you would like to delete this to do by typing \"yes\"");
                string deleteC = Console.ReadLine();
                if (deleteC == "yes")
                {
                    List1.toDoChosen[2] = "";
                    ToDos.Main1();
                }
                else
                {
                    ToDos.Main1();
                }
            }
            else
            {
                while (toDoC != "E" || toDoC != "D")
                {
                    goto ToDoCStart;
                }
            }
            Console.ReadKey();
        }
    }
}
