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
            /*using(FileStream fs = new FileStream("login.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine("Some new text");
                writer.WriteLine("Another line of text");
            }*/
            Console.WriteLine("Please enter a value from 'A','B','C' or 'D' ");
            foreach (string ToDo in List1.toDoChosen)
            {
                Console.WriteLine(ToDo);
            }

            string toDo = Console.ReadLine().ToUpper();
            while (!List1.toDoChosen.Contains(toDo))
            {
                Console.WriteLine("Please pick from the above list");
                toDo = Console.ReadLine().ToUpper();
            }
            if (List1.toDoChosen.Contains(toDo))
            {
                if (toDo == "A")
                {
                    Console.WriteLine("You have chosen to do A");
                    ToDoA.ToDo1();
                }
                else if (toDo == "B")
                {
                    Console.WriteLine("You have chosen to do B");
                    ToDoB.ToDo2();
                }
                else if (toDo == "C")
                {
                    Console.WriteLine("You have chosen to do C");
                    ToDoC.ToDo3();
                }
                else if (toDo == "D")
                {
                    Console.WriteLine("You have chosen to do D");
                    ToDoD.ToDo4();
                }
            }
            else
            {
                Console.WriteLine("Please pick from the above list");
            }
            Console.ReadKey();
        end: { }
        }
    }
}

