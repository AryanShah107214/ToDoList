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
            
            foreach (string ToDo in Program.toDoChosen)
            {
                Console.WriteLine(ToDo);//prints all items in list
            }

            string toDo = Console.ReadLine();
            while (!Program.toDoChosen.Contains(toDo))//if to do entered by user is not in the list, it prompts user to try again
            {
                Console.WriteLine("Please pick from the above list");
                toDo = Console.ReadLine();
            }
            if (Program.toDoChosen.Contains(toDo))
            {
                if(toDo==Program.toDoChosen[0])
                {
                    Console.WriteLine("You have chosen the 1st to do");
                    ToDoA.ToDo1();//takes user to 1st to do by calling the function
                }
                else if (toDo == Program.toDoChosen[1])
                {
                    Console.WriteLine("You have chosen the 2nd to do");//takes user to 2nd to do by calling the function
                    ToDoB.ToDo2();
                }
                else if (toDo == Program.toDoChosen[2])
                {
                    Console.WriteLine("You have chosen the 3rd to do");//takes user to 3rd to do by calling the function
                    ToDoC.ToDo3();
                }
                else if (toDo == Program.toDoChosen[3])
                {
                    Console.WriteLine("You have chosen the 4th to do");//takes user to 4th to do by calling the function
                    ToDoD.ToDo4();
                }
            }
            else
            {
                Console.WriteLine("Please pick from the above list");
            }
            Console.ReadKey();
        
        }
    }
}

