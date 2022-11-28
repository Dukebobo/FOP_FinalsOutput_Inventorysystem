/*
Complete code: https://github.com/Dukebobo/FOP_FinalsOutput_Inventorysystem

Code File describe:  Main method in program.cs;
Project: FOP finals output
Group: Group 3
Submit Date: 5:22 PM, Nov 18, 2022 

Renfrence: https://www.youtube.com/watch?v=az8mHaJXpRE
*/

using ConsoleApp1;
using System;

namespace Inventorysystem
{
    public class Program
    { 
        public static void Main(string[] args)
        {

            Console.Title = "Inventory system";  //define console application windows title
            
            login.loginGate(); // login method 
            
            Console.ReadKey();
        
        
        }
    
    }
    
}
