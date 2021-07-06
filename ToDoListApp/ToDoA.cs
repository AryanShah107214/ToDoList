using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    public class ToDoA : ToDos
    {

        public static void ToDo1()
        {
        ToDoAStart:
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen To Do -- A. Edit or Delete (E/D)?");
            string toDoA = Console.ReadLine().ToUpper();
            if (toDoA == "E")
            {
                Console.WriteLine("You have chosen to edit");
                Console.WriteLine("What would you like to change it to");
                string changesToA = Console.ReadLine();
                List1.toDoChosen[0] = changesToA;
                Console.WriteLine("You have succesfully changed the value of To Do A to " + changesToA);
                ToDos.Main1();
            }
            else if (toDoA == "D")
            {
                Console.WriteLine("Please confirm that you would like to delete this to do by typing \"yes\"");
                string deleteA = Console.ReadLine();
                if (deleteA == "yes")
                {
                    List1.toDoChosen[0] = "";
                    ToDos.Main1();
                }
                else
                {
                    ToDos.Main1();
                }

            }
            else
            {
                while (toDoA != "E" || toDoA != "D")
                {
                    goto ToDoAStart;
                }
            }
            Console.ReadKey();
        }
    }
}
