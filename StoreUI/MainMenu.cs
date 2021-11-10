/*using System;
using StoreModels;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class MainMenu : IMenu
    {
        public static string _findStoreName;
        public void Menu()
        {
            string title = @"
        
+-+-+-+-+-+-+-+-+-+-+-+-+-+ +-+-+-+-+
|H|a|c|k|T|h|e|P|l|a|n|e|t| |I|n|c|.|
+-+-+-+-+-+-+-+-+-+-+-+-+-+ +-+-+-+-+                                                                                  
";
            Console.WriteLine(title);
            Console.WriteLine("Your GPU, CyberWare, and Cybernetics Depot!\n Select an option from the Main Menu.");
            Console.WriteLine("[1] - Create an Account ");
            Console.WriteLine("[2] - List Store Locations.");
            Console.WriteLine("[3] - Search Store Locations.");
            Console.WriteLine("[4] - Enter our store page.");
            //Console.WriteLine("[5] - Inventory Menu.");
            Console.WriteLine("[6] - Exit");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    
                    return MenuType.CustomerSignUp;
                case "2":
                    
                    return MenuType.ListStore;
                case "3":
                    Console.WriteLine("Enter a name for the Store, you want to find");
                    _findStoreName = Console.ReadLine();
                    
                    return MenuType.QueryStore;
                case "4":
                    
                    return MenuType.StoreMenu;
                case "5":
                    return MenuType.InventoryMenu;
                case "6":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}
*/