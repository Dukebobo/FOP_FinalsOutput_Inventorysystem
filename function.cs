/*
Complete code: https://github.com/Dukebobo/FOP_FinalsOutput_Inventorysystem

Code File describe: array,constructor,if..else, for loop, escape character，
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
    
    public class function
    {
        //declare stock structure
        public struct stock
        {
        public string sku;
        public string itemname;
        public string category;
        public float qty;
        public float price;
        public float value;
        };
        
        //add items
        public static void add(stock[] st, ref int itemcount)
        {

        Again:
            Console.WriteLine("======================================================\n            ADDING STOCK DATA/INFORMATION                         \n======================================================");
            Console.Write("Enter stocks SKU:");
            st[itemcount].sku = Console.ReadLine().ToString();

            if (search(st, st[itemcount].sku, itemcount) != -1)
            {
                Console.Clear();
                Console.WriteLine("The SKU Number you Enter already exists.");
                goto Again;

            }


            Console.Write("Enter Item NAME: ");
            st[itemcount].itemname = Console.ReadLine().ToString();
            Console.Write("Enter Item CATEGORY: ");
            st[itemcount].category = Console.ReadLine().ToString();
            Console.Write("Enter Item QUANTITY:");
            st[itemcount].qty = float.Parse(Console.ReadLine());
            Console.Write("Enter Item PRICE:");
            st[itemcount].price = float.Parse(Console.ReadLine());
            st[itemcount].value = st[itemcount].qty * st[itemcount].price;
            ++itemcount;

        }
        //item delete
        public static void delete(stock[] st, ref int itemcount)
        {
            string id;
            int index;
            if (itemcount > 0)
            {
                Console.WriteLine("======================================================\n         DELETING STOCK DATA/INFORMATION                         \n======================================================");
                Console.Write("Enter Item SKU:");
                id = Console.ReadLine();
                index = search(st, id.ToString(), itemcount);

                if ((index != -1) && (itemcount != 0))
                {
                    if (index == (itemcount - 1))
                    {

                        clean(st, index);
                        --itemcount;

                        Console.WriteLine("The record was deleted.");
                    }
                    else
                    {
                        for (int i = index; i < itemcount - 1; i++)
                        {
                            st[i] = st[i + 1];
                            clean(st, itemcount);
                            --itemcount;
                        }
                    }
                }
                else Console.WriteLine("The record doesn't exist. Check the SKU ID and try again.");
            }
            else Console.WriteLine("No record to delete");
        }
        //items edit
        public static void update(stock[] st, int itemcount)
        {
            string id;
            int column_index;
            Console.WriteLine("======================================================\n           UPDATE STUDENTS DATA/INFORMATION                         \n======================================================");
            Console.Write("Enter Item SKU ID:");
            id = Console.ReadLine();
            Console.WriteLine("Which field you want to update(1-4)?:");
            Console.WriteLine("1: ItemName");
            Console.WriteLine("2: ItemCategory");
            Console.WriteLine("3: ItemQuantity");
            Console.WriteLine("4: ItemPrice");
            Console.WriteLine("******************************************************\n");
            column_index = int.Parse(Console.ReadLine());
            int index = search(st, id.ToString(), itemcount);
            if ((index != -1) && (itemcount != 0))
            {
                if (column_index == 1)
                {
                    Console.Write("Enter Item NAME: ");
                    st[index].itemname = Console.ReadLine().ToString();
                }

                else if (column_index == 2)
                {
                    Console.Write("Enter ItemCategory :");
                    st[index].category = Console.ReadLine().ToString();
                }
                else if (column_index == 3)
                {
                    Console.Write("Enter Item Quantity: ");
                    st[index].qty = float.Parse(Console.ReadLine());
                }
                else if (column_index == 4)
                {
                    Console.Write("Enter ItemPrice: ");
                    st[index].price = float.Parse(Console.ReadLine());
                }
                else Console.WriteLine("Invalid column index");
                st[index].value = st[index].qty + st[index].price;
            }
            else Console.WriteLine("The record deosn't exits.Check the ID and try again.");

        }


        //update escape characters code  Make the display more tidy.
        //display all items
        public static void viewall(stock[] st, int itemcount)
        {

            int i = 0;
            Console.WriteLine("====================================================================================================================\n                                                STOCK DATA/INFORMATION          \n====================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("{0,-5}\t\t{1,-20}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-9}(column index)", "0","1", "2", "3", "4", "5");
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.WriteLine("{0,-5}\t\t{1,-20}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-9}", "SKU ID", "ITEM NAME", "CATEGORY", "QUANTITY", "PRICE", "VALUE");
            Console.WriteLine("====================================================================================================================");

            while (i < itemcount)
            {

                if (st[i].sku != null)
                {
                    Console.Write("{0,-5}\t{1,-20}\t{2,-10}", st[i].sku, st[i].itemname, st[i].category);
                    Console.Write("\t{0,-9}\t{1,-9}\t{2,-9}", st[i].qty, st[i].price, st[i].value.ToString("N"));        // Thousands display.
                    Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");
                }

                i = i + 1;
            }
        }
         //find  
        public static void find(stock[] st, int itemcount)
        {
            Console.WriteLine("======================================================\n                     SEARCH STOCKS                         \n======================================================");
            string id;
            Console.Write("Enter Item SKU:");
            id = Console.ReadLine();

            int index = search(st, id.ToString(), itemcount);
            if (index != -1)
            {
                Console.Write("{0,-5}\t{1,-20}{2,-5}", st[index].sku, st[index].itemname, st[index].category);
                Console.Write("{0,-5}{1,-5}\t{2,-5}", st[index].qty, st[index].price, st[index].value.ToString("N"));//update Thousands display.
                Console.WriteLine();

            }
            else Console.WriteLine("The record doesn't exits.");
        }
        
        //search 
        public static int search(stock[] st, string id, int itemcount)
        {
            int found = -1;
            for (int i = 0; i < itemcount && found == -1; i++)
            {

                if (st[i].sku == id) found = i;

                else found = -1;
            }

            return found;

        }
        
        //clean
        public static void clean(stock[] st, int index)
        {
            st[index].sku = null;
            st[index].itemname = null;
            st[index].category = null;
            st[index].qty = 0;
            st[index].price = 0;
            st[index].value = 0;

        }

    }
}
