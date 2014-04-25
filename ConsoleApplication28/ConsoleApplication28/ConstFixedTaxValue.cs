/****************************** Module Header ******************************\
Module Name     :   Constant values
File Name       :   ConstFixedTaxValue.cs
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
    // class uses for staore the constant vlaues
    public class ConstFixedTaxValue
    {
        // Sales tax
        public const double SALES_TAX = 10;

        //import tax
        public const double SALES_IMPORT_TAX = 5;

        //round 2 decimal
        public const int TWO_DECIMAL = 2;

        // value for calculate percentage
        public const int PERCENTAGE = 100;

        //values uses for rounded up to the earest 0.05) amount of sales tax
        public const int ROUNDUP = 20;

    }
}
