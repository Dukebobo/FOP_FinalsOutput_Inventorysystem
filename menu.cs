/*
Code File describe: Menu do-while loog and switch 
Project: FOP finals output
Group: Group 3
Submit Date: 5:22 PM, Nov 18, 2022 
Renfrence: https://www.youtube.com/watch?v=az8mHaJXpRE
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class menu
    {
        public static void choiceMenu()
        {
            const int MAX = 20000;//create an array to store 20000 stocks
            try
            {
                stock[] st = new stock[MAX];
                int itemcount = 0;
                int choice;
                string confirm;

                do
                {     //show menu
                    displaymenu();
                    Console.Write("Enter your choice(1~6):");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            function.add(st, ref itemcount);
                            break;
                        case 2:
                            function.delete(st, ref itemcount);
                            break;
                        case 3:
                            function.update(st, itemcount);
                            break;
                        case 4:
                            function.viewall(st, itemcount);
                            break;
                        case 5:
                            function.find(st, itemcount);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("invalid");
                            break;
                    }

                    Console.Write("Press y or Y to continue:");
                    confirm = Console.ReadLine().ToString();
                    Console.Clear();
                } while (confirm == "y" || confirm == "Y");
            }
            catch (FormatException) { Console.WriteLine("Invalid input"); }
            Console.ReadLine();
        }

        public static void displaymenu()
        {
            {
                string logo = @" __        __   _                          
 \ \      / /__| | ___ ___  _ __ ___   ___ 
  \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \
   \ V  V /  __/ | (_| (_) | | | | | |  __/
    \_/\_/ \___|_|\___\___/|_| |_| |_|\___|
                                           ";
                Console.WriteLine(logo);
            }

            Console.WriteLine("======================================================\n                         MENU                         \n======================================================");
            Console.WriteLine(" 1.Add stock records");
            Console.WriteLine(" 2.Delete stock records");
            Console.WriteLine(" 3.Update stock records");
            Console.WriteLine(" 4.View all stock records");
            Console.WriteLine(" 5.Find a stock by SKU");
            Console.WriteLine(" 6.Exit ");
            Console.WriteLine("******************************************************\n");
        }
    }
}
