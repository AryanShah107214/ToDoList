using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    class ToDoD : Program
    {
        public static void ToDo4()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen to do --" + Program.toDoChosen[3] + ". Edit or Finish To Do (E/F)?");
        ToDoDStart:
            string toDoD = Console.ReadLine().ToUpper();
            if (toDoD == "E")
            {

                Console.WriteLine("You have chosen to edit");
                Console.WriteLine("What would you like your to do to display");
            edit:
                Console.Write("Answer: ");
                string changesToD = Console.ReadLine();
                Program.toDoChosen[3] = changesToD;
                if (changesToD == " ")
                {
                    changesToD = null;//so it can be checked by bool IsEmpty
                }
                bool IsEmpty = string.IsNullOrEmpty(changesToD);//checks if the string is empty or null
                if (!IsEmpty)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("You have succesfully changed the value of the 4th To Do to " + changesToD);
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
            else if (toDoD == "F")
            {
                Console.WriteLine("Please confirm that you would like to finish this to do by typing \"yes\". Else, type \"no\"");
                Console.Write("Answer: ");
                string finishD = Console.ReadLine();
            finish:
                if (finishD == "yes")
                {
                    Program.toDoChosen[3] = "To Do D Finished";//displays To Do A Finished so user knows they have completed the to do
                    Console.Clear();
                    ToDos.Main1();
                }
                else if (finishD == "no")
                {
                    Console.Clear();
                    ToDos.Main1();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You typed " + finishD + " .");
                    Console.ResetColor();
                    Console.WriteLine("Type any key to advance");
                    while (finishD != "yes" || finishD != "no")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please type either \"yes\" or \"no\"");
                        Console.ResetColor();
                        Console.Write("Answer: ");
                        finishD = Console.ReadLine();
                        goto finish;
                    }
                    if (finishD == "yes")
                    {
                        goto finish;
                    }
                    else if (finishD == "no")
                    {
                        Console.Clear();
                        ToDos.Main1();
                    }

                }

            }
            else
            {
                while (toDoD != "E" || toDoD != "F")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type either 'E' or 'F' ");
                    Console.ResetColor();
                    goto ToDoDStart;//if user didn't enter one of the accepted answers
                }
            }
            Console.ReadKey();
        }
    }
}
