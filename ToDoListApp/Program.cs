using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace ToDoListApp
{
    public class Program
    {
        public static List<string> toDoChosen = new List<string>() { "1", "2", "3", "4" };//stores to dos and is outside the main function so it can be accessed by other classes
        static void Main()
        {
            Console.WriteLine("Hello, welcome to my to do list app.");
            Console.WriteLine("You can view, update and delete your to do items.");
            Console.WriteLine("Type any key to advance");
            Console.ReadKey();
            Console.Clear();//clears console
            
            
            foreach(string ToDo in toDoChosen)
            {
                Console.WriteLine(ToDo);//prints to do options
            }

            Console.WriteLine("Please enter a value from '1','2','3' or '4' ");
            string toDo = Console.ReadLine();
            while (!toDoChosen.Contains(toDo))//if to do entered by user is not in the list, it prompts user to try again
            {
                Console.WriteLine("Please pick from the above list");
                toDo = Console.ReadLine();
            }
            if (toDoChosen.Contains(toDo))
            {
                Console.WriteLine("You chose to do - " + toDo);
                if (toDo == Program.toDoChosen[0])
                {
                    ToDoA.ToDo1();
                }
                else if (toDo == Program.toDoChosen[1])
                {
                    ToDoB.ToDo2();
                }
                else if (toDo == Program.toDoChosen[2])
                {
                    ToDoC.ToDo3();
                }
                else if (toDo == Program.toDoChosen[3])
                {
                    ToDoD.ToDo4();
                }
            }
            Console.ReadKey();
        }
    }
    }
