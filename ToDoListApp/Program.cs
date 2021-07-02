using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arrUsers = new User[];

            Console.WriteLine("Hello, welcome to my to do list app.");
            Console.WriteLine("You can create, view, update and delete your to do items.");
            Console.WriteLine("Type any key to advance");
            Console.ReadKey();
            Console.WriteLine("Type \"1\" for login and \"2\" to register");
            string LoR = Console.ReadLine();


            Console.Clear();
            Login.LoginSystem();
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
                ToDoA.ToDo1();
            }
            else
            {
                Console.WriteLine("Please pick from the above list");
            }
            Console.ReadKey();
        end: { }
        }



        public class Login
        {
            public static void LoginSystem()
            {
                Console.WriteLine("Please enter your username");
                Console.WriteLine("Please enter your password");
                string LogIn = Console.ReadLine();
                Dictionary<string, string> UserNamePassword = new Dictionary<string, string>();
               /* foreach (Login in string.Parse(UserNamePassword))
                {
                    Login.Contains(i);
                }
                
                if (Login.Contains(UserNamePassword[0]))
                {
                    Console.WriteLine("You have succesfully logged in");
                }
                else
                {
                    Console.WriteLine("Your login details do not match any existing accounts");
                }*/
            }
        }
        public class Registration : Login
        {
            
            /*  public static void UserRegistration()
              {
                  Console.WriteLine("What is your first name");
                  Console.ReadLine();
                  Console.WriteLine("What is your last name");
                  Console.ReadLine();
                  Console.WriteLine("Enter your username");
                  string userNameInput = Console.ReadLine();
                  Console.WriteLine("Enter a password");
                  Console.ReadLine();
                  Console.WriteLine("Confirm Password");
                  string passWordInput = Console.ReadLine();
              }*/
        }
        
        
    }
    }
