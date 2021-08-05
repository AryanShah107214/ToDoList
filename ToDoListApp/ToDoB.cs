using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    class ToDoB
    {
        public static void ToDo2()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen to do --" + Program.toDoChosen[1] + ". Edit or Finish To Do (E/F)?");
        ToDoBStart:
            string toDoB = Console.ReadLine().ToUpper();
            if (toDoB == "E")
            {

                Console.WriteLine("You have chosen to edit");
                Console.WriteLine("What would you like your to do to display");
            edit:
                Console.Write("Answer: ");
                string changesToB = Console.ReadLine();
                Program.toDoChosen[1] = changesToB;
                if (changesToB == " ")
                {
                    changesToB = null;//so it can be checked by bool IsEmpty
                }
                bool IsEmpty = string.IsNullOrEmpty(changesToB);//checks if the string is empty or null
                if (!IsEmpty)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("You have succesfully changed the value of the 2nd To Do to " + changesToB);
                    Console.ResetColor();
                    Console.Write("\nType any key to advance");
                    Console.ReadKey();
                    Console.Clear();
                    ToDos.Main1();
                }
                else
                {

                    goto edit;//takes user to labelled statement - edit
                }

            }
            else if (toDoB == "F")
            {
                Console.WriteLine("Please confirm that you would like to finish this to do by typing \"yes\". Else, type \"no\"");
                Console.Write("Answer: ");
                string finishB = Console.ReadLine();
            finish:
                if (finishB == "yes")
                {
                    Program.toDoChosen[1] = "To Do B Finished";//displays To Do A Finished so user knows they have completed the to do
                    Console.Clear();
                    ToDos.Main1();
                }
                else if (finishB == "no")
                {
                    Console.Clear();
                    ToDos.Main1();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You typed " + finishB + " .");
                    Console.ResetColor();
                    Console.WriteLine("Type any key to advance");
                    while (finishB != "yes" || finishB != "no")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please type either \"yes\" or \"no\"");
                        Console.ResetColor();
                        Console.Write("Answer: ");
                        finishB = Console.ReadLine();
                        goto finish;
                    }
                    if (finishB == "yes")
                    {
                        goto finish;
                    }
                    else if (finishB == "no")
                    {
                        ToDos.Main1();
                    }

                }

            }
            else
            {
                while (toDoB != "E" || toDoB != "F")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type either 'E' or 'F' ");
                    Console.ResetColor();
                    goto ToDoBStart;//if user didn't enter one of the accepted answers
                }
            }
            Console.ReadKey();
        }
    }
}
