/*
using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class QueryCustomer : IMenu
    {
        private IStoreBL _storeBL;
        
        public QueryCustomer(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        
        public void Menu()
        {
            Console.WriteLine("--Search Results--");
            List<Customer> listOfCustomer = _storeBL.GetCustomerName(AddCustomer._findCustName);
            
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
                    return MenuType.QueryCustomer;
            }
        }
    }
}

*/