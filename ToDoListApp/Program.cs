using System;
using System.Linq;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my to do list app.");
            Console.WriteLine("You can create, view, update and delete your to do items.");
            Console.WriteLine("Type exit any time you would like to exit.");



            Console.WriteLine("Type 'yes' to continue");
            string Continue = Console.ReadLine().ToLower();
            if (Continue == "yes")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Are you sure you'd like to exit?(Y/N)");

                string YN = Console.ReadLine();
                if(YN == "y")
                {
                    Console.WriteLine("You have chosen to continue");
                }
                else
                {
                    Console.WriteLine("Enter to exit");
                    goto end;
                }
            }
            Console.WriteLine("Please enter a value from 'A','B','C' or 'D' ");
            string[] toDoChosen = { "A", "B", "C", "D" };

            string toDo = Console.ReadLine().ToUpper();
            while (!toDoChosen.Contains(toDo))
            {
                Console.WriteLine("Please pick from the above list");
                toDo = Console.ReadLine().ToUpper();
            }
            if (toDoChosen.Contains(toDo))
            {
                Console.WriteLine("You chose to do - " + toDo);
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
    
