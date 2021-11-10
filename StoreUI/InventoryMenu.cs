/*using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;



namespace StoreUI
{
    public class InventoryMenu : IMenu
    {

        private IStoreBL _storeBL;
        private IInventoryBL _invBL;
        
        public InventoryMenu(IStoreBL p_storeBL, IInventoryBL p_invBL)
        {
            this._storeBL = p_storeBL;
            this._invBL = p_invBL;
        }
       public void Menu()
        {
            Console.WriteLine("--Inventory Menu--");
            
            Console.WriteLine("[1] - List Line Items ");
            Console.WriteLine("[2] - Select a LineItem(ID) to Replenish.");
            Console.WriteLine("[0] - Go Back");
        }

//PrintAllProducts();
        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    _storeBL.PrintAllProducts();
                     //List<LineItem> listOfLine = _storeBL.GetAllLineItemInventory();
                    Console.WriteLine("====================");
                    Console.WriteLine("Press Enter to return to Store Menu options.");
                    Console.ReadLine();
                return MenuType.InventoryMenu;
                   case "2":
                    Console.WriteLine("Enter the Product Id to replenish inventory. ");
                    try
                    {
                        int linId = Int32.Parse(Console.ReadLine());
                        Inventory linFound = _invBL.GetItemById(linId);

                        Console.WriteLine("Input how much you want to add to inventory.");
                        int addedInventory = Int32.Parse(Console.ReadLine());
                        _invBL.ReplenishLineById(linFound, addedInventory);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Please input a number and not a character!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.InventoryMenu;
                    }

                    return MenuType.InventoryMenu;

                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.InventoryMenu;
            }
        }
    }
}

   
*/