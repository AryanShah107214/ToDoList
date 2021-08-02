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
            Console.WriteLine("What would you like to do with your chosen to do - "+ Program.toDoChosen[3] + ". Edit or Finish To Do (E/F)");
        ToDoDStart:
            string toDoD = Console.ReadLine().ToUpper();
            if (toDoD == "E")
            {
                edit:
                Console.WriteLine("You have chosen to edit");
                Console.WriteLine("What would you like to change it to");
                string changesToD = Console.ReadLine();
                Program.toDoChosen[3] = changesToD;
                if (changesToD == " ")
                {
                    changesToD = null;//so it can be checked by bool IsEmpty
                }
                bool IsEmpty = string.IsNullOrEmpty(changesToD);//checks if the string is empty or null
                if (!IsEmpty)
                {
                    Console.WriteLine("You have succesfully changed the value of the 1st To Do to " + changesToD);
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
                Console.WriteLine("Please confirm that you would like to finish this to do by typing \"yes\"");
                string finishD = Console.ReadLine();
                finish:
                if (finishD == "yes")
                {
                    Program.toDoChosen[3] = "To Do D Finished";//displays To Do D Finished so user knows they have completed the to do
                    Console.Clear();
                    ToDos.Main1();
                }
                else if(finishD == "no")
                {
                    ToDos.Main1();
                }
                else
                {
                    Console.WriteLine("You typed" + finishD + "\nType any key to advance");
                    Console.ReadKey();
                    while (finishD != "yes" || finishD != "no")
                    {
                        Console.WriteLine("Please type either \"yes\" or \"no\"");
                        finishD = Console.ReadLine();
                        goto finish;
                    }
                    if (finishD == "yes")
                    {
                        goto finish;
                    }
                    else if (finishD == "no")
                    {
                        ToDos.Main1();
                    }
                }
            }
            else
            {
                while (toDoD != "E" || toDoD != "D")
                {
                    Console.WriteLine("Please type either 'E' or 'F' ");
                    goto ToDoDStart;
                }
            }
            Console.ReadKey();
        }
    }
}
