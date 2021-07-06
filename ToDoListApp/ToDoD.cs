using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    class ToDoD:Program
    {
        public static void ToDo4()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen To Do -- A. Edit or Delete the To Do (E/D)");
            string toDoD = Console.ReadLine().ToUpper();
            if (toDoD == "E")
            {
                Console.WriteLine("You have chosen to edit");
                Console.ReadLine();
                Console.WriteLine("What would you like to change it to");
            }
            else if (toDoD == "D")
            {
                Console.WriteLine("Please confirm that you would like to delete this to do by typing \"yes\"");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please select one of the above");
            }
            Console.ReadKey();
        }
    }
}
