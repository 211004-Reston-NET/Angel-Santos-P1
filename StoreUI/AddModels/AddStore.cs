/*
using System;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class AddStore : IMenu
    {
        private static StoreFront _store = new StoreFront();
        private IStoreBL _storeBL;
         
        public AddStore(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine("Adding a new Store");
            Console.WriteLine("Name - " + _store.StoreName);
            Console.WriteLine("State - "+ _store.Address);
            Console.WriteLine("City - "+ _store.City);
            Console.WriteLine("State - "+ _store.State);
            Console.WriteLine("[1] - Input value for Name");
            Console.WriteLine("[2] - Input value for Street Address");
            Console.WriteLine("[3] - Input value for City");
            Console.WriteLine("[4] - Input value for State");
            Console.WriteLine("[5] - Add Store");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "5":
                    //Anything inside the try block will be catched if an exception has risen
                    //Laymen's term if a problem has happened while doing this code, it will instead do the catch block
                    try
                    {
                         _storeBL.AddStore(_store);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddStore;
                    }
                    return MenuType.StoreMenu;
                case "3":
                    Console.WriteLine("Type in the value for the Name");
                    _store.StoreName = Console.ReadLine();
                    return MenuType.AddStore;
                case "2":
                    Console.WriteLine("Type in the value for the State");
                    _store.State = Console.ReadLine();
                    return MenuType.AddStore;
                case "1":
                    Console.WriteLine("Type in the value for the City");
                    _store.City = Console.ReadLine();
                    return MenuType.AddStore;
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ListStore;
            }
        }
    }
}
*/