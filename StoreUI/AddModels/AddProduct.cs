using System;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class AddProduct : IMenu
    {
        private static Product _prod = new Product();
        private IStoreBL _storeBL;
         
        public AddProduct(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine("Adding a new Product");
            Console.WriteLine("Name - " + _prod.ItemName);
            Console.WriteLine("Category - "+ _prod.Category);
            Console.WriteLine("Price - "+ _prod.Price);
            Console.WriteLine("Description - "+ _prod.Description);
            Console.WriteLine("[1] - Input value for Name");
            Console.WriteLine("[2] - Input value for Category");
            Console.WriteLine("[3] - Input value for Price");
            Console.WriteLine("[4] - Input value for Description");
            Console.WriteLine("[5] - Add Product");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                
                case "1":
                    Console.WriteLine("Type in the value for the Name");
                    _prod.ItemName = Console.ReadLine();
                    return MenuType.AddProduct;
                case "2":
                    Console.WriteLine("Type in the value for the Category");
                    _prod.Category = Console.ReadLine();
                    return MenuType.AddProduct;
                case "3":
                    Console.WriteLine("Type in the value for the Price");
                    _prod.Price = Decimal.Parse(Console.ReadLine());
                    return MenuType.AddProduct;
                case "4":
                    Console.WriteLine("Type in the value for the Description");
                    _prod.ItemName = Console.ReadLine();
                    return MenuType.AddProduct;
                case "5":
                    //Anything inside the try block will be catched if an exception has risen
                    //Laymen's term if a problem has happened while doing this code, it will instead do the catch block
                    try
                    {
                         _storeBL.AddProduct(_prod);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddProduct;
                    }
                    return MenuType.StoreMenu;
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ListProduct;
            }
        }
    }
}