/*
Complete code: https://github.com/Dukebobo/FOP_FinalsOutput_Inventorysystem

Code File describe: Menu do-while loop and switch  and try catch;
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
            
            //try....catch
            try
            {
                function.stock[] st = new function.stock[MAX]; //cerate a array st , size 20000
                int itemcount = 0;  // array st index
                int choice; // menu choice number 
                string confirm; //do ... while loop conditional  variable

                do
                {     // using do while loop  and switch  to make a menu choice function . 
                    displaymenu();  //display menu choice 
                    Console.Write("Enter your choice(1~6):");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    
                    switch (choice)
                    {
                        case 1:
                            function.add(st, ref itemcount); //add method - add new item
                            break;
                        case 2:
                            function.delete(st, ref itemcount);//delete method - delete items
                            break;
                        case 3:
                            function.update(st, itemcount);//update method - edit items
                            break;
                        case 4:
                            function.viewall(st, itemcount);//viewall  method -display all items
                            break;
                        case 5:
                            function.find(st, itemcount);//find method - find item by sku number
                            break;
                        case 6:
                            Environment.Exit(0);  // exit program
                            break; 
                        default:
                            Console.WriteLine("Invalid input, Please input 1~6 or press Ctrl + C to exit. ");
                            break;
                    }

                    Console.Write("Press y or Y to continue:");
                    confirm = Console.ReadLine().ToString(); // get do ... while loop conditional value 
                    Console.Clear();
                } while (confirm == "y" || confirm == "Y"); // do ... while loop conditional value 
            }
            catch (FormatException) { Console.WriteLine("Invalid input, Pleases input Y "); }
          
            Console.ReadLine();
        }

        
        public static void displaymenu()  //display menu method 
        {
            
                string logo = @" __        __   _                          
 \ \      / /__| | ___ ___  _ __ ___   ___ 
  \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \
   \ V  V /  __/ | (_| (_) | | | | | |  __/
    \_/\_/ \___|_|\___\___/|_| |_| |_|\___|
                                           ";
            Console.WriteLine(logo);  //display logo 
            
             
            Console.WriteLine("======================================================\n                         MENU                         \n======================================================");
            Console.WriteLine(" 1.Add stock records");
            Console.WriteLine(" 2.Delete stock records");
            Console.WriteLine(" 3.Update stock records");
            Console.WriteLine(" 4.View all stock records");
            Console.WriteLine(" 5.Find a stock by SKU");
            Console.WriteLine(" 6.Exit ");
            Console.WriteLine("******************************************************\n"); 
            
            Console.ReadLine();
        }
    }
}
