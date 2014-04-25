/****************************** Module Header ******************************\
Module Name     :   Main Program
File Name       :   Program.cs
Created by      :   Selvam Ramasamy
Project         :   Sales Tax
Copyright(c)    :   thoughtworks

<Description of the file>
\***************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication28
{
    public class Program
    {

        // use the following method for invoke from VisualStudio UnitTesting TestTools
         public Boolean test(SalesItems[] item)
        {
     
            try
            {
                CalculateTax caltx = new CalculateTax(item);
                SalesReceipt sr = new SalesReceipt(caltx);

                Console.WriteLine();
                sr.PrintItemswithTax();
                sr.PrintTotalSalesTax();
                sr.PrintTotal();
                Console.WriteLine();
            }
            catch (ArgumentNullException e)        // If the argument is null, throw ArgumentNullException and fail the test case
            {
                Console.WriteLine("ArgumentNullException {0}", e.Message);
                return false;  //fail the test case
            }

            return true; // Pass the test case
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Run this application from Microsoft VisualStudio UnitTesting TestTools for 3 test cases ");
            Console.WriteLine();

            // Create Object for test this application
            Program p = new Program();

            //SalesReceipt 
            SalesItems[] item = new SalesItems[2];

            // Create SalesItems Object
            for (int i = 0; i < 2; i++)
            {
                item[i] = new SalesItems();
            }

            // Initilize 1st
            item[0].Name = "imported box of chocolates";
            item[0].Price = 10.00;
            item[0].ImportFlag = true;
            item[0].NoOfItems = 1;
            item[0].ExemptFlag = true;

            // Initilize 2nd
            item[1].Name = "imported bottle of perfume";
            item[1].Price = 47.50;
            item[1].ImportFlag = true;
            item[1].NoOfItems = 1;
            item[1].ExemptFlag = false;

            // invoke the test case
            p.test(item);

            Console.WriteLine();
        }
    }
}
