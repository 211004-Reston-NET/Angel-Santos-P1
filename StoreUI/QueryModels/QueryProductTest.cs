/*using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class QueryProduct : IMenu
    {
        private IStoreBL _storeBL;
        
        public QueryProduct(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        
        public void Menu()
        {
            Console.WriteLine("--Search Results--");
            List<Product> listOfProduct = _storeBL.GetProductName(ListProduct._findProdName.Name);
            
            foreach (Product prod in listOfProduct)
            {
                Console.WriteLine("====================");
                Console.WriteLine(prod);
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
                    return MenuType.ListProduct;
                
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.QueryProduct;
            }
        }
    }
}

*/