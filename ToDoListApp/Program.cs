using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace ToDoListApp
{
    public class Program
    {
        public static List<string> toDoChosen = new List<string>() { "To Do A", "To Do B", "To Do C", "To Do D" };
        public static List<string> toDoNums = new List<string>() { "1", "2", "3", "4"};//stores to dos and is outside the main function so it can be accessed by other classes
        static void Main()
        {
            Console.WriteLine("Hello, welcome to my to do list app.");
            Console.WriteLine("You can view, update and delete your to do items.");
            Console.WriteLine("Type any key to advance");
            Console.ReadKey();
            Console.Clear();//clears console

            int ListNum = 0;
            Console.WriteLine("Below are the available lists");
            foreach (string ToDo in toDoChosen)
            {
                ListNum++;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(ListNum + ". " + ToDo);//prints to do options
            }
            Console.ResetColor();
            Console.WriteLine("Please type a list number to view a list\n");
            Console.Write("Enter list number: ");
            string toDo = Console.ReadLine();
            while (!toDoNums.Contains(toDo))//if to do entered by user is not in the list, it prompts user to try again
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please pick from the above list: ");
                Console.ResetColor();
                toDo = Console.ReadLine();
            }
            switch(int.Parse(toDo))
            {
                case 1:
                    Console.WriteLine("You chose the 1st to do");
                    ToDoA.ToDo1();
                    break;
                case 2:
                    Console.WriteLine("You chose the 2nd to do");
                    ToDoB.ToDo2();
                    break;
                case 3:
                    Console.WriteLine("You chose the 3rd to do");
                    ToDoC.ToDo3();
                    break;
                case 4:
                    Console.WriteLine("You chose the 4th to do");
                    ToDoD.ToDo4();
                    break;
            }
            Console.ReadKey();
        }
    }
    }
