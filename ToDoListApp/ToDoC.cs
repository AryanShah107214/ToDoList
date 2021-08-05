using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    class ToDoC : Program
    {
        public static void ToDo3()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen to do --" + Program.toDoChosen[2] + ". Edit or Finish To Do (E/F)?");
        ToDoCStart:
            string toDoC = Console.ReadLine().ToUpper();
            if (toDoC == "E")
            {

                Console.WriteLine("You have chosen to edit");
                Console.WriteLine("What would you like your to do to display");
            edit:
                string changesToC = Console.ReadLine();
                Program.toDoChosen[2] = changesToC;
                if (changesToC == " ")
                {
                    changesToC = null;//so it can be checked by bool IsEmpty
                }
                bool IsEmpty = string.IsNullOrEmpty(changesToC);//checks if the string is empty or null
                if (!IsEmpty)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("You have succesfully changed the value of the 3rd To Do to " + changesToC);
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
            else if (toDoC == "F")
            {
                Console.WriteLine("Please confirm that you would like to finish this to do by typing \"yes\". Else, type \"no\"");
                string finishC = Console.ReadLine();
            finish:
                if (finishC == "yes")
                {
                    Program.toDoChosen[2] = "To Do B Finished";//displays To Do B Finished so user knows they have completed the to do
                    Console.Clear();
                    ToDos.Main1();
                }
                else if (finishC == "no")
                {
                    ToDos.Main1();
                }
                else
                {
                    Console.WriteLine("You typed " + finishC + "\nType any key to advance");
                    Console.ReadKey();
                    while (finishC != "yes" || finishC != "no")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please type either \"yes\" or \"no\"");
                        finishC = Console.ReadLine();
                        Console.ResetColor();
                        goto finish;
                    }
                    if (finishC == "yes")
                    {
                        goto finish;
                    }
                    else if (finishC == "no")
                    {
                        ToDos.Main1();
                    }

                }

            }
            else
            {
                while (toDoC != "E" || toDoC != "F")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type either 'E' or 'F' ");
                    Console.ResetColor();
                    goto ToDoCStart;//if user didn't enter one of the accepted answers
                }
            }
            Console.ReadKey();
        }
    }
}
