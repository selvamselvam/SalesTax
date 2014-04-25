/****************************** Module Header ******************************\
Module Name     :   Calculate Tax
File Name       :   CalculateTax.cs
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
    // CalculateTax class implements ICalculateTax interface
    public class CalculateTax : ICalculateTax
    {
        // Array of SalesItems for each item
        private SalesItems[] item = null;
        
        // Create tax
        private Tax tax = null;
        
        // total tax and item amount
        private double tot = 0;
        
        // only total Tax 
        private double totaltax = 0.0;

        // public cons for init the SalesItems values
        public CalculateTax(SalesItems[] it)
        {
            tax = new Tax();
            item = it;
        }

        // Calculate the Toal TaxItem Amount
        public Hashtable CaluculateToalTaxItemAmount()
        {
            //create hashtable for store the total amount and item name
            Hashtable h = new Hashtable(item.Length); 

            for (int i = 0; i < item.Length; i++)
            {
                tax = new Tax(); // create object for each item
                tax.CalculateTax(item[i]); // calculate the tax
                tot = tax.TotalItemAmount(item[i].Price,item[i].NoOfItems);// get the total amount
                h.Add(item[i].Name, tot); // Add in Hashatable
            }

            return h; // return heash table

        }


        // method for calculate the total sales tax
        public double TotalSalesTax()
        {
            // calculate the total sales tax amount
            for (int i = 0; i < item.Length; i++)
            {
                tax = new Tax();
                tax.CalculateTax(item[i]);
                totaltax = totaltax + tax.TotalTaxAmount();
            }

            //return the rounded up to the nearest 0.05) amount of sales tax
            return Math.Ceiling(totaltax * 20) / 20;
        }

    }
}
