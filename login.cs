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
            

                string logo = @"
 __      _____ _    ___ ___  __  __ ___ 
 \ \    / / __| |  / __/ _ \|  \/  | __|
  \ \/\/ /| _|| |_| (_| (_) | |\/| | _| 
   \_/\_/ |___|____\___\___/|_|  |_|___|
                                        
                               ";
                Console.WriteLine(logo); //print login-logo 

            
            string user, password; //declaration of the variable user and password
            Console.WriteLine("Please enter username："); 
            while (true) //while loop
            {
                user = Console.ReadLine();
                if (string.IsNullOrEmpty(user))
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
                        if (password.Equals("demo"))
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
                                if (password.Equals("demo"))
                                {
                                    break;
                                }
                            }
                            if (password.Equals("demo"))
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
