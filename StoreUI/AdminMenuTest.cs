/*using System;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            string title = @"
        
+-+-+-+-+-+-+-+-+-+-+-+-+-+ +-+-+-+-+
|H|a|c|k|T|h|e|P|l|a|n|e|t| |I|n|c|.|
+-+-+-+-+-+-+-+-+-+-+-+-+-+ +-+-+-+-+                                                                                  
";
            Console.WriteLine(title);
            Console.WriteLine("GPUs, CyberWare, Cybernetic Peripherals, We Have It All!\n Please, select an option from the Main Menu.");
            Console.WriteLine("[1] - Create an Account ");
            Console.WriteLine("[2] - List Store Locations.");
            Console.WriteLine("[3] - Search Store Locations.");
            Console.WriteLine("[4] - Enter our store page.");
            Console.WriteLine("[5] - Exit");
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
                    return MenuType.ListStore;
                case "4":
                    return MenuType.StoreMenu;
                case "5":
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