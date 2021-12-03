using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineStrategy;
using System;
using System.Collections.Generic;

namespace PromotionEngineStrategyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DisplayCustomerOrder()
        {
            //Fill the SKU ids and their unit prices
            CustomerOrder customerList = new CustomerOrder();

            //Get the order from user
            customerList.GetOrderFromUser('A', 3);
            customerList.GetOrderFromUser('B', 2);
            customerList.GetOrderFromUser('C', 1);
            customerList.GetOrderFromUser('D', 1);

            //Display the list from customer
            customerList.DisplayOrderCount();
        }

        [TestMethod]
        public void TestInput()
        {
            //Fill the SKU ids and their unit prices
            CustomerOrder customerList = new CustomerOrder();

            //Get the order from user
            customerList.GetOrderFromUser(' ', 3);
            customerList.GetOrderFromUser('B', 2);
            customerList.GetOrderFromUser('C', 1);
            customerList.GetOrderFromUser('D', 1);

            //Display the list from customer
            customerList.DisplayOrderCount();
        }


        [TestMethod]
        public void ScenarioA()
        {
            //Fill the SKU ids and their unit prices
            CustomerOrder customerList = new CustomerOrder();

            //Get the order from user
            customerList.GetOrderFromUser('A', 1);
            customerList.GetOrderFromUser('B', 1);
            customerList.GetOrderFromUser('C', 1);
            customerList.GetOrderFromUser('D', 0);

            //Display the list from customer
            customerList.DisplayOrderCount();

            Dictionary<char, int> OriginalCustomerOrder = new Dictionary<char, int>();
            OriginalCustomerOrder = customerList.listItems;

            //create a context
            Context context = new Context();

            //=======================================ACTIVE PROMOTIONS===================================//
            //Apply Fixed price combination for A and B
            Console.WriteLine("Activating fixed price Promotion");
            FixedPromotionTypeAB fixObj = new FixedPromotionTypeAB();
            context.SetPromotionStrategy(fixObj);
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);
            double price = fixObj.GetNetPrice();
            //Assert
            Assert.IsTrue(price == 80);

            //Apply Combo price combination for C and D
            Console.WriteLine("Activating combo price Promotion");
            ComboPromotionTypeCD comboObj = new ComboPromotionTypeCD();
            context.SetPromotionStrategy(comboObj);
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);
            double comboprice = comboObj.GetNetPrice();
            //Assert
            Assert.IsTrue(comboprice == 100);
        }

        [TestMethod]
        public void ScenarioB()
        {
            //Fill the SKU ids and their unit prices
            CustomerOrder customerList = new CustomerOrder();

            //Get the order from user
            customerList.GetOrderFromUser('A', 5);
            customerList.GetOrderFromUser('B', 5);
            customerList.GetOrderFromUser('C', 1);
            customerList.GetOrderFromUser('D', 0);

            //Display the list from customer
            customerList.DisplayOrderCount();

            Dictionary<char, int> OriginalCustomerOrder = new Dictionary<char, int>();
            OriginalCustomerOrder = customerList.listItems;

            //create a context
            Context context = new Context();

            //=======================================ACTIVE PROMOTIONS===================================//
            //Apply Fixed price combination for A and B
            Console.WriteLine("Activating fixed price Promotion");
            FixedPromotionTypeAB fixObj = new FixedPromotionTypeAB();
            context.SetPromotionStrategy(fixObj);
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);
            double price = fixObj.GetNetPrice();
            //Assert
            Assert.IsTrue(price == 450);

            //Apply Combo price combination for C and D
            Console.WriteLine("Activating combo price Promotion");
            ComboPromotionTypeCD comboObj = new ComboPromotionTypeCD();
            context.SetPromotionStrategy(comboObj);
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);
            double comboprice = comboObj.GetNetPrice();
            //Assert
            Assert.IsTrue(comboprice == 470);
        }

        [TestMethod]
        public void ScenarioC()
        {
            //Fill the SKU ids and their unit prices
            CustomerOrder customerList = new CustomerOrder();

            //Get the order from user
            customerList.GetOrderFromUser('A', 3);
            customerList.GetOrderFromUser('B', 5);
            customerList.GetOrderFromUser('C', 1);
            customerList.GetOrderFromUser('D', 1);

            //Display the list from customer
            customerList.DisplayOrderCount();

            Dictionary<char, int> OriginalCustomerOrder = new Dictionary<char, int>();
            OriginalCustomerOrder = customerList.listItems;

            //create a context
            Context context = new Context();

            //=======================================ACTIVE PROMOTIONS===================================//
            //Apply Fixed price combination for A and B
            Console.WriteLine("Activating fixed price Promotion");
            FixedPromotionTypeAB fixObj = new FixedPromotionTypeAB();
            context.SetPromotionStrategy(fixObj);
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);
            double price = fixObj.GetNetPrice();
            //Assert
            Assert.IsTrue(price == 250);

            //Apply Combo price combination for C and D
            Console.WriteLine("Activating combo price Promotion");
            ComboPromotionTypeCD comboObj = new ComboPromotionTypeCD();
            context.SetPromotionStrategy(comboObj);
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);
            double comboprice = comboObj.GetNetPrice();
            //Assert
            Assert.IsTrue(comboprice == 280);
        }

        [TestMethod]
        public void ScenarioD()
        {
            //Fill the SKU ids and their unit prices
            CustomerOrder customerList = new CustomerOrder();

            //Get the order from user
            customerList.GetOrderFromUser('A', 30);
            customerList.GetOrderFromUser('B', 20);
            customerList.GetOrderFromUser('C', 1);
            customerList.GetOrderFromUser('D', 1);

            //Display the list from customer
            customerList.DisplayOrderCount();

            Dictionary<char, int> OriginalCustomerOrder = new Dictionary<char, int>();
            OriginalCustomerOrder = customerList.listItems;

            //create a context
            Context context = new Context();

            //=======================================ACTIVE PROMOTIONS===================================//
            //Apply Fixed price combination for A and B
            Console.WriteLine("Activating fixed price Promotion");
            FixedPromotionTypeAB fixObj = new FixedPromotionTypeAB();
            context.SetPromotionStrategy(fixObj);
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);
            double price = fixObj.GetNetPrice();
            //Assert
            Assert.IsTrue( price == 1750);

            //Apply Combo price combination for C and D
            Console.WriteLine("Activating combo price Promotion");
            ComboPromotionTypeCD comboObj = new ComboPromotionTypeCD();
            context.SetPromotionStrategy(comboObj);
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);
            double comboprice = comboObj.GetNetPrice();
            //Assert
            Assert.IsTrue(comboprice == 1780);
        }

        [TestMethod]
        public void ScenarioPercentage()
        {
            //Fill the SKU ids and their unit prices
            CustomerOrder customerList = new CustomerOrder();

            //Get the order from user
            customerList.GetOrderFromUser('A', 1);
            customerList.GetOrderFromUser('B', 1);
            customerList.GetOrderFromUser('C', 1);
            customerList.GetOrderFromUser('D', 0);

            //Display the list from customer
            customerList.DisplayOrderCount();

            Dictionary<char, int> OriginalCustomerOrder = new Dictionary<char, int>();
            OriginalCustomerOrder = customerList.listItems;

            //create a context
            Context context = new Context();

            //=======================================ACTIVE PROMOTIONS===================================//
            //Apply percentage promotion
            PercentagePromotionType obj = new PercentagePromotionType();
            Console.WriteLine("Activating fixed price Promotion");
            context.SetPromotionStrategy(obj);
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);
                        

            //Assert
            Assert.IsTrue(obj.price==50);
        }

        [TestMethod]
        public void ScenarioNoPromotion()
        {
            //Fill the SKU ids and their unit prices
            CustomerOrder customerList = new CustomerOrder();

            //Get the order from user
            customerList.GetOrderFromUser('A', 1);
            customerList.GetOrderFromUser('B', 1);
            customerList.GetOrderFromUser('C', 1);
            customerList.GetOrderFromUser('D', 1);

            //Display the list from customer
            customerList.DisplayOrderCount();

            Dictionary<char, int> OriginalCustomerOrder = new Dictionary<char, int>();
            OriginalCustomerOrder = customerList.listItems;

            //create a context
            Context context = new Context();

            //=======================================ACTIVE PROMOTIONS===================================//
            //Apply Fixed price combination for A and B
            Console.WriteLine("Activating fixed price Promotion");
            NoPromotionType Obj = new NoPromotionType();
            context.SetPromotionStrategy(Obj);
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);
          
            //Assert
            Assert.IsTrue(Obj.price == 115);

        }

    }
}
