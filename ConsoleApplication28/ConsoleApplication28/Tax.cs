/****************************** Module Header ******************************\
Module Name     :    Tax
File Name       :   Tax.cs
Created by      :   Selvam Ramasamy
Project         :   Sales Tax
Copyright(c)    :   thoughtworks

<Description of the file>
\***************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication28
{
    // implement the itax interface
    public class Tax : ITax
    {
        // calculate the exempt sales tax
        private double exemptamount = 0.0;

        // calculate the import sales tax
        private double importamount = 0.0;

        //calculate the total amount
        private double totalamount = 0.0;

        //private method for round the salesrounded up to the nearest 0.05
        private double RoundSalesTax(double salesTax)
        {
            return Math.Ceiling(salesTax * ConstFixedTaxValue.ROUNDUP) / ConstFixedTaxValue.ROUNDUP;
        }

        //calculate the tax based on ExemptFlag and ImportFlag
        public void CalculateTax(SalesItems sitem)
        {
            if (sitem.ExemptFlag == false) // calculate only for sales tax itmes
            {
                exemptamount = (sitem.Price * sitem.NoOfItems * ConstFixedTaxValue.SALES_TAX) / ConstFixedTaxValue.PERCENTAGE;
            }

            if (sitem.ImportFlag == true) // validate for imported items
            {
                importamount = (sitem.Price * sitem.NoOfItems * ConstFixedTaxValue.SALES_IMPORT_TAX) / ConstFixedTaxValue.PERCENTAGE;
            }
        }


        //total item amount including exemptamount and importamount tax
        public double TotalItemAmount(double amount, int noofitmes)
        {
            totalamount = (noofitmes * amount) + exemptamount + importamount;
            return RoundSalesTax(totalamount);
            
        }

        // toal tax item for each item
        public double TotalTaxAmount()
        {
            return RoundSalesTax(exemptamount + importamount);
        }

    }
}
