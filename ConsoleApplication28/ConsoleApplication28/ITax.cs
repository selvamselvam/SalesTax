/****************************** Module Header ******************************\
Module Name     :   Interface Tax
File Name       :   ITax.cs
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
    public interface ITax
    {
         // use for calculate the total item amount
         double TotalItemAmount(double amount, int noofitmes);
         
        // use for calculate the total tax amount
         double TotalTaxAmount();

         // use for calculate the tax amount
         void CalculateTax(SalesItems sitem);
    }
}
