using System;


namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a boolean that has either a false or true value
            //I will use this to stop the while loop
            bool repeat = true;


            IFactory factory = new MenuFactory();

            //This is example of polymorphism, abstraction, and inheritance all at the same time
            IMenu page = factory.GetMenu(MenuType.MainMenu);

            //This is a while loop that will keep repeating until I changed the
            //repeat variable to false
            while (repeat)
            {
                //Clean terminal screen
                Console.Clear();

                
                page.Menu();
                MenuType currentPage = page.UserChoice();

                // Switch case will change the page variable to point to 
                // another object to change the menu 
                if (currentPage == MenuType.Exit)
                {
                    Console.WriteLine("You are exiting the application!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    repeat = false;
                }
                else
                {
                    page = factory.GetMenu(currentPage);
                }
            }
        }
    }
}
