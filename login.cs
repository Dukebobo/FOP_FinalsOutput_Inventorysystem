/*
Code File describe: loginLoop  while loop
Project: FOP finals output
Group: Group 3
Submit Date: 5:22 PM, Nov 18, 2022 
Renfrence: https://www.youtube.com/watch?v=az8mHaJXpRE
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class login
    {
        public static void loginGate()
        {

            string user, password;
            Console.WriteLine("Please enter username：");
            while (true)
            {
                user = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(user))
                {
                    Console.WriteLine("Username can not be empty! please check and enter again：");
                }
                else
                {
                    if (user.Equals("demo"))
                    {
                        Console.WriteLine("Please enter password：");
                        password = Console.ReadLine();
                        if (string.IsNullOrEmpty(password))
                        {
                            Console.WriteLine("Password can not be empty! please check and enter again：");
                            password = Console.ReadLine();
                        }
                        if (password == "demo")
                        {
                            Console.WriteLine("\n Login successful");
                            menu.choiceMenu();
                            break;
                        }
                        else
                        {
                            while (true)
                            {
                                if (string.IsNullOrEmpty(password))
                                {
                                    Console.WriteLine("Password can not be empty! please check and enter again：");
                                }
                                else
                                {
                                    Console.WriteLine("Password is incorrect, please cehck and enter again：");
                                }
                                password = Console.ReadLine();
                                if (password == "demo")
                                {
                                    break;
                                }
                            }
                            if (password == "demo")
                            {
                                Console.WriteLine("\n Login successful");
                                menu.choiceMenu();
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Username is incorrect, please cehck and enter again：");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
