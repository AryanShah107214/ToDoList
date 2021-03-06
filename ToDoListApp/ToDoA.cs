using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    public class ToDoA : ToDos
    {
        public static void ToDo1()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do with your chosen to do --"+ Program.toDoChosen[0] +". Edit or Finish To Do (E/F)?");
        ToDoAStart:
            string toDoA = Console.ReadLine().ToUpper();
            if (toDoA == "E")
            {
                
                Console.WriteLine("You have chosen to edit");
                Console.WriteLine("What would you like your to do to display");
            edit:
                Console.Write("Answer: ");
                string changesToA = Console.ReadLine();
                Program.toDoChosen[0] = changesToA;
                if (changesToA == " ")
                {
                    changesToA = null;//so it can be checked by bool IsEmpty
                }
                bool IsEmpty = string.IsNullOrEmpty(changesToA);//checks if the string is empty or null
                if (!IsEmpty)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("You have succesfully changed the value of the 1st To Do to " + changesToA);
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
            else if (toDoA == "F")
            {
                Console.WriteLine("Please confirm that you would like to finish this to do by typing \"yes\". Else, type \"no\"");
                Console.Write("Answer: ");
                string finishA = Console.ReadLine();
                finish:
                if (finishA == "yes")
                {
                    Program.toDoChosen[0] = "To Do A Finished";//displays To Do A Finished so user knows they have completed the to do
                    Console.Clear();
                    ToDos.Main1();
                }
                else if(finishA=="no")
                {
                    Console.Clear();
                    ToDos.Main1();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You typed " + finishA + " .");
                    Console.ResetColor();
                    Console.WriteLine("Type any key to advance");
                    Console.ReadKey();
                    while(finishA!="yes"|| finishA!="no")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please type either \"yes\" or \"no\"");
                        Console.ResetColor();
                        Console.Write("Answer: ");
                        finishA = Console.ReadLine();
                        goto finish;
                    }
                    if(finishA == "yes")
                    {
                        goto finish;
                    }
                    else if(finishA == "no")
                    {
                        ToDos.Main1();
                    }
                    
                }

            }
            else
            {
                while (toDoA != "E" || toDoA != "F")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type either 'E' or 'F' ");
                    Console.ResetColor();
                    goto ToDoAStart;//if user didn't enter one of the accepted answers
                }
            }
            Console.ReadKey();
        }
    }
}
