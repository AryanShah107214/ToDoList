using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    public class ToDoA
    {
        
        public static void ToDo1()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen To Do -- A. Edit or Delete the To Do (E/D)");
            string toDoA = Console.ReadLine().ToUpper();
            if(toDoA == "E")
            {
                Console.WriteLine("You have chosen to edit");
                Console.ReadLine();
                Console.WriteLine("What would you like to change it to");
            }
            else if(toDoA == "D")
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
