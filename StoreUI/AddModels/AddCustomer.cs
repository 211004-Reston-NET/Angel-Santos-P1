/*
using System;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class AddCustomer : IMenu
    {
        private static Customer _customer = new Customer();
        private IStoreBL _storeBL;
        public static string _findCustName;
         
        public AddCustomer(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine(" Please, add your credentials. ");
            Console.WriteLine("First Name - " + _customer.FirstName);
            Console.WriteLine("Last Name - " + _customer.LastName);
            Console.WriteLine("Street Address - "+ _customer.StreetAddress);
            Console.WriteLine("Email - "+ _customer.Email);
            Console.WriteLine("[1] - Input First Name");
            Console.WriteLine("[2] - Input Last Name");
            Console.WriteLine("[3] - Input Street Address");
            Console.WriteLine("[4] - Input Email");
            Console.WriteLine("[5] - Submit completed information.");
            Console.WriteLine("[6] - List all customers.");
            Console.WriteLine("[7] - Search for a customer.");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "5":
                //'try' block will 'catch' if exception arises, prevents interruption 
                // through exception handling
                    try
                    {
                         _storeBL.CustomerSignUp(_customer);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input values to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.CustomerSignUp;
                    }

                    return MenuType.MainMenu;
                case "1":
                    Console.WriteLine("Type in your First Name.");
                    try
                    {
                         _customer.FirstName = Console.ReadLine();
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must use only letters.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.CustomerSignUp;
                    }
                    return MenuType.CustomerSignUp;
                case "2":
                    Console.WriteLine("Type in your Last Name.");
                    try
                    {
                    _customer.LastName = Console.ReadLine();
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("You must use only letters.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.CustomerSignUp;
                    }
                    return MenuType.CustomerSignUp;
                case "3":
                    Console.WriteLine("Type in the value for the Street Address.");
                    try
                    {
                    _customer.StreetAddress = Console.ReadLine();
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("You must enter a valid Address.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.CustomerSignUp;
                    }
                    return MenuType.CustomerSignUp;
                case "4":
                    Console.WriteLine("Type in the value for your Email.");
                    try
                    {
                    _customer.Email = Console.ReadLine();
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("You must enter a valid Address.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.CustomerSignUp;
                    }
                    return MenuType.CustomerSignUp;
                case "6":
                   return MenuType.GetAllCustomer;
                case "7":
                    Console.WriteLine("Enter a name for the Customer, you want to find");
                    _findCustName = Console.ReadLine();
                   return MenuType.QueryCustomer;
               
                case "0":
                    return MenuType.CustomerSignUp;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CustomerSignUp;
            }
        }
    }
}
*/