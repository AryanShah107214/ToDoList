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
                string changesToA = Console.ReadLine();
                Program.toDoChosen[0] = changesToA;
                if (changesToA == " ")
                {
                    changesToA = null;//so it can be checked by bool IsEmpty
                }
                bool IsEmpty = string.IsNullOrEmpty(changesToA);//checks if the string is empty or null
                if (!IsEmpty)
                {
                    Console.WriteLine("You have succesfully changed the value of the 1st To Do to " + changesToA);
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
                    ToDos.Main1();
                }
                else
                {
                    Console.WriteLine("You typed" + finishA + "\nType any key to advance");
                    Console.ReadKey();
                    while(finishA!="yes"|| finishA!="no")
                    {
                        Console.WriteLine("Please type either \"yes\" or \"no\"");
                        finishA=Console.ReadLine();
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
                    Console.WriteLine("Please type either 'E' or 'F' ");
                    goto ToDoAStart;//if user didn't enter one of the accepted answers
                }
            }
            Console.ReadKey();
        }
    }
}
