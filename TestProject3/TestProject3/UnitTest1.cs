using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication28;
namespace TestProject3
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
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
        }

        [TestMethod]
        public void TestMethod2()
        {
            Program p = new Program();
            //SalesReceipt 
            SalesItems[] item = new SalesItems[3];

            //SalesItems item = new SalesItems();
            try
            {
                // Create SalesItems Object
                for (int i = 0; i < 3; i++)
                {
                    item[i] = new SalesItems();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Initilize 1st
            item[0].Name = "book";
            item[0].Price = 12.49;
            item[0].ImportFlag = false;
            item[0].NoOfItems = 1;
            item[0].ExemptFlag = true;

            // Initilize 2nd
            item[1].Name = "music CD";
            item[1].Price = 14.99;
            item[1].ImportFlag = false;
            item[1].NoOfItems = 1;
            item[1].ExemptFlag = false;

            // Initialize 3rd
            item[2].Name = "chocolate bar";
            item[2].Price = 0.85;
            item[2].ImportFlag = false;
            item[2].NoOfItems = 1;
            item[2].ExemptFlag = true;

            p.test(item);
        }


        [TestMethod]
        public void TestMethod3()
        {
            Program p = new Program();
            //SalesReceipt 
            SalesItems[] item = new SalesItems[4];

            //SalesItems item = new SalesItems();
            try
            {
                // Create SalesItems Object
                for (int i = 0; i < 4; i++)
                {
                    item[i] = new SalesItems();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




            // Initilize 1st
            item[0].Name = "imported bottle of perfume";
            item[0].Price = 27.99;
            item[0].ImportFlag = true;
            item[0].NoOfItems = 1;
            item[0].ExemptFlag = false;

   


            
            // Initilize 2nd
            item[1].Name = "bottle of perfume";
            item[1].Price = 18.99;
            item[1].ImportFlag = false;
            item[1].NoOfItems = 1;
            item[1].ExemptFlag = false;

            // Initialize 3rd
            item[2].Name = "packet of headache pills";
            item[2].Price = 9.75;
            item[2].ImportFlag = false;
            item[2].NoOfItems = 1;
            item[2].ExemptFlag = true;


             // Initialize 3rd
            item[3].Name = "box of imported chocolates";
            item[3].Price = 11.25;
            item[3].ImportFlag = true;
            item[3].NoOfItems = 1;
            item[3].ExemptFlag = true;


            p.test(item);
        }

    }
}
