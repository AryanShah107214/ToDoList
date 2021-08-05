using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace ToDoListApp
{
    public class ToDos
    {
        public static void Main1()
        {
            Console.WriteLine("Please enter a value from the below list ");
            int ListNum = 0;
            Console.WriteLine("Below are the available lists");
            foreach (string ToDo in Program.toDoChosen)
            {
                ListNum++;
                Console.WriteLine(ListNum + ". " + ToDo);//prints to do options
            }
            Console.Write("\nEnter list number: ");
            string toDo = Console.ReadLine();
            while (!Program.toDoNums.Contains(toDo))//if to do entered by user is not in the list, it prompts user to try again
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please pick from the above list: ");
                toDo = Console.ReadLine();
                Console.ResetColor();
            }
            switch (int.Parse(toDo))//used instead of if else statements and uses the int - 'toDo' to switch between cases
            {
                case 1:
                    ToDoA.ToDo1();
                    break;
                case 2:
                    ToDoB.ToDo2();
                    break;
                case 3:
                    ToDoC.ToDo3();
                    break;
                case 4:
                    ToDoD.ToDo4();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please pick one of the above");
                    Console.ResetColor();
                    break;
            }
            
            Console.ReadKey();
        
        }
    }
}

