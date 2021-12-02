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
            context.SetPromotionStrategy(new FixedPromotionTypeAB());
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);

            //Apply Combo price combination for C and D
            Console.WriteLine("Activating combo price Promotion");
            context.SetPromotionStrategy(new ComboPromotionTypeCD());
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);

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
            context.SetPromotionStrategy(new FixedPromotionTypeAB());
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);

            //Apply Combo price combination for C and D
            Console.WriteLine("Activating combo price Promotion");
            context.SetPromotionStrategy(new ComboPromotionTypeCD());
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);

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
            context.SetPromotionStrategy(new FixedPromotionTypeAB());
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);

            //Apply Combo price combination for C and D
            Console.WriteLine("Activating combo price Promotion");
            context.SetPromotionStrategy(new ComboPromotionTypeCD());
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);

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
            context.SetPromotionStrategy(new FixedPromotionTypeAB());
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);

            //Apply Combo price combination for C and D
            Console.WriteLine("Activating combo price Promotion");
            context.SetPromotionStrategy(new ComboPromotionTypeCD());
            customerList.listItems = context.ApplyPromotion(customerList.listItems, customerList.priceInOrder);

        }

    }
}