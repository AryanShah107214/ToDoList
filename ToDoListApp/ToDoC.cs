using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    class ToDoC:Program
    {
        public static void ToDo3()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen To Do -- A. Edit or Delete the To Do (E/D)");
            string toDoC = Console.ReadLine().ToUpper();
            if (toDoC == "E")
            {
                Console.WriteLine("You have chosen to edit");
                Console.ReadLine();
                Console.WriteLine("What would you like to change it to");
            }
            else if (toDoC == "D")
            {
                Console.WriteLine("Please confirm that you would like to delete this to do by typing \"yes\"");
                Console.ReadLine();
            }
            else
            {

            }
            Console.ReadKey();
        }
    }
}
