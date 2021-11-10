/*
using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;


namespace StoreUI
{
    public class ListStore : IMenu
    {
        private IStoreBL _storeBL;
        public static StoreFront _findStoreName = new StoreFront();
        public ListStore(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Stores");
            List<StoreFront> listOfStore = _storeBL.GetAllStore();

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
                    return MenuType.MainMenu;
                case "1":
                    Console.WriteLine("Enter a name for the Store you want to find");
                    _findStoreName.StoreName = Console.ReadLine();
                    return MenuType.QueryStore;
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