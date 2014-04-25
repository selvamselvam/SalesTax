/****************************** Module Header ******************************\
Module Name     :   SalesReceipt
File Name       :   SalesReceipt.cs
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
    public class SalesReceipt
    {

        // init the CalculateTax for print the values
        private CalculateTax caltax = null;

        //find the total sales tax
        private double total = 0.0;

        //hastable for find the total amount and item desc
        Hashtable h = null;

        // init the CalculateTax and calculate the tax amounts
        public SalesReceipt(CalculateTax ct)
        {
            caltax = ct;
            h = caltax.CaluculateToalTaxItemAmount();
        }

        // print the items and tax including amount
        public void PrintItemswithTax()
        {
            foreach (DictionaryEntry de in h)
            {
                Console.WriteLine("1 {0}: {1}", de.Key, de.Value);
            }

        }

        //print the total sales tas
	    public void PrintTotalSalesTax()
        {
            Console.WriteLine("Sales Taxes: {0}", caltax.TotalSalesTax());
         }

        public void PrintTotal()
        {
            // To get the values alone, use the Values property.
            ICollection valueColl = h.Values;

            // The elements of the ValueCollection are strongly typed with the type that was specified for hash table values.
            foreach (double s in valueColl)
            {
                total = total + s;
            }

            Console.WriteLine("Total: {0}", Math.Round(total, 2));
        }

    }
}
