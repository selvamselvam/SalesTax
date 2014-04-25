/****************************** Module Header ******************************\
Module Name     :   ICalculateTax
File Name       :   ICalculateTax.cs
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
    public interface ICalculateTax
    {
        // use for calculate the total tax and item amount
         Hashtable CaluculateToalTaxItemAmount();

         // use for calcultae the total sales tax
         double TotalSalesTax();
    }
}
