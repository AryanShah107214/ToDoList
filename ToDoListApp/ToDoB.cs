using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    class ToDoB
    {
        public static void ToDo2()
        {
        ToDoBStart:
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen To Do -- B. Edit or Delete the To Do (E/D)");
            string toDoB = Console.ReadLine().ToUpper();
            if (toDoB == "E")
            {
                Console.WriteLine("You have chosen to edit");
                Console.WriteLine("What would you like to change it to");
                string changesToB = Console.ReadLine();
                List1.toDoChosen[1] = changesToB;
                Console.WriteLine("You have succesfully changed the value of To Do B to " + changesToB);
                ToDos.Main1();
            }
            else if (toDoB == "D")
            {
                Console.WriteLine("Please confirm that you would like to delete this to do by typing \"yes\"");
                string deleteB = Console.ReadLine();
                if (deleteB == "yes")
                {
                    List1.toDoChosen[1] = "";
                    ToDos.Main1();
                }
                else
                {
                    ToDos.Main1();
                }
            }
            else
            {
                while (toDoB != "E" || toDoB != "D")
                {
                    goto ToDoBStart;
                }
            }
            Console.ReadKey();
        }
    }
}
