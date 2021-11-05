using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class QueryStore : IMenu
    {
        private IStoreBL _storeBL;
        
        public QueryStore(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        
        public void Menu()
        {
            Console.WriteLine("--Search Results--");
            List<StoreFront> listOfStore = _storeBL.GetStoreName(MainMenu._findStoreName);
            
            foreach (StoreFront store in listOfStore)
            {
                Console.WriteLine("====================");
                Console.WriteLine(store);
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
                    return MenuType.ListStore;
                
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.QueryStore;
            }
        }
    }
}

