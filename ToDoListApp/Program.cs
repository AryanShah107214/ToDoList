using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var UserArr = new Users[]
        {
            new Users("aryan","shah"),
            new Users("dan","smith"),
            new Users("cooper","coop")
        };

            //Console.WriteLine("Hello, welcome to my to do list app.");
            //Console.WriteLine("You can create, view, update and delete your to do items.");
            //Console.WriteLine("Type any key to advance");
            //Console.ReadKey();
            Start: 
            Console.WriteLine("Type \"1\" for login and \"2\" to register");
            string LoR = Console.ReadLine();

            bool correctLogin = false;
            while(!correctLogin)
            {
                if(LoR == "1")
                {
                    Console.WriteLine("Please type your username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Please type your password");
                    string password = Console.ReadLine();
                    foreach (Users user in UserArr)
                    {
                        if (username == user.username && password == user.password)
                        {
                            Console.WriteLine("You have successfully logged in !!!");
                            Console.ReadLine();
                            correctLogin = true;
                            break;
                        }
                    }

                    if (!correctLogin)
                    {
                        Console.WriteLine("Your username or password is incorect, try again !!!");
                    }
                }
                else if(LoR == "2")
                {
                    Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();
            
                Array.Resize(ref UserArr, UserArr.Length + 1);
                UserArr[UserArr.Length - 1] = new Users(username, password);
                correctLogin = true;
                Console.WriteLine("You have sucessfully registered");

            }
            else
            {
                Console.WriteLine("Try again !!!");
                goto Start;



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
                //Console.WriteLine("Please enter your username");
                //Console.WriteLine("Please enter your password");
                //string LogIn = Console.ReadLine();
                //Dictionary<string, string> UserNamePassword = new Dictionary<string, string>();
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

        public class Users
        {
            public string username;
            public string password;

            public Users(string username, string password)
            {
                this.username = username;
                this.password = password;
            }
        }


    }
    }
