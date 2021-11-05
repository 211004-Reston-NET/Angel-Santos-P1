using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;


namespace StoreUI
{
    public class ListCustomer : IMenu
    {
        private IStoreBL _storeBL;
        public static Customer _findCustName = new Customer();
        public ListCustomer(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Customers");
            List<Customer> listOfCustomer = _storeBL.GetAllCustomers();

            foreach (Customer cust in listOfCustomer)
            {
                Console.WriteLine("====================");
                Console.WriteLine(cust);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.GetAllCustomer;
            }
        }
    }
}

