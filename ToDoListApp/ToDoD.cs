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
        toDoDStart:
            string toDoD = Console.ReadLine().ToUpper();
            if (toDoD == "E")
            {

                Console.WriteLine("You have chosen to edit");
                Console.WriteLine("What would you like your to do to display");
            edit:
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
                    Console.Write("You have succesfully changed the value of the 2nd To Do to " + changesToD);
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
                string finishB = Console.ReadLine();
            finish:
                if (finishB == "yes")
                {
                    Program.toDoChosen[1] = "To Do B Finished";//displays To Do B Finished so user knows they have completed the to do
                    Console.Clear();
                    ToDos.Main1();
                }
                else if (finishB == "no")
                {
                    ToDos.Main1();
                }
                else
                {
                    Console.WriteLine("You typed " + finishB + "\nType any key to advance");
                    Console.ReadKey();
                    while (finishB != "yes" || finishB != "no")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please type either \"yes\" or \"no\"");
                        finishB = Console.ReadLine();
                        Console.ResetColor();
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
                while (toDoD != "E" || toDoD != "F")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type either 'E' or 'F' ");
                    Console.ResetColor();
                    goto toDoDStart;//if user didn't enter one of the accepted answers
                }
            }
            Console.ReadKey();
        }
    }
}
