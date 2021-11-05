/*using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;


namespace StoreUI
{
    public class ListProduct : IMenu
    {
        private IStoreBL _storeBL;
        public static Product _findProdName = new Product();
        public static Product _findProdCategory = new Product();
        
        public ListProduct(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Products");
            List<Product> listOfProduct = _storeBL.GetAllProduct();
            
            foreach (Product prod in listOfProduct)
            {
                Console.WriteLine("====================");
                Console.WriteLine(prod);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Search a Name of a Product");
            Console.WriteLine("[2] - WIP - Search a Category of a Product");
            Console.WriteLine("[0] - Go Back");
        }

        /*public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.StoreMenu;
                case "1":
                    Console.WriteLine("Enter a name for the Product, you want to find");
                    _findProdName.Name = Console.ReadLine();
                    return MenuType.QueryProduct;
                case "2":
                    Console.WriteLine("Enter the Category of the Product you want to find");
                    try
                    {
                         _findProdName.Category = Console.ReadLine();
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please put in letters!");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        return MenuType.QueryProduct;
                    }
                    return MenuType.QueryProduct;
                
                default:
                    return MenuType.ListProduct;
            }
        }
    }
}

*/