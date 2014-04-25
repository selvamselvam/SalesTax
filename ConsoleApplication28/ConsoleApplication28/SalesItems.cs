/****************************** Module Header ******************************\
Module Name     :   SalesItems 
File Name       :   SalesItems.cs
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
    public class SalesItems
    {
        // name of the product
        private string name = "";

        //price of the item
	    private double price = 0.0;

        //import flag for identify import
	    private Boolean importFlag = true;

        //exempt flag for ignore the slaes tax
	    private Boolean exemptFlag = true;

        //no of items
        private int noOfItems = 0;


        // find the Name
        public string Name    // the Name property
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // find the Price
        public double Price // the Price property
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }

        }

        // find the ImportFlag
        public Boolean ImportFlag // the ImportFlag property
        {
            get
            {
                return importFlag;
            }
            set
            {
                importFlag = value;
            }

        }

        // find the ExemptFlag
        public Boolean ExemptFlag // the ExemptFlag property
        {
            get
            {
                return exemptFlag;
            }
            set
            {
                exemptFlag = value;
            }

        }

        // find the number of items
        public int NoOfItems  // the NoOfItems property
        {
            get
            {
                return noOfItems;
            }
            set
            {
                noOfItems = value;
            }

        }



    }
}
