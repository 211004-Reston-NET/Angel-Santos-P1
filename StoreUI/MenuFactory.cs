using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StoreBL;
using StoreDL;



namespace StoreUI
{
    /// <summary>
    /// Designed to create menu objects
    /// </summary>
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder() //Configurationbuilder is the class that came from the Microsoft.extensions.configuration package
                .SetBasePath(Directory.GetCurrentDirectory()) //using System.IO - Gets the current directory of the StoreUI file path
                .AddJsonFile("appsetting.json") //Adds the appsetting.json file in our StoreUI
                .Build(); //Builds our configuration

            DbContextOptions<DBp0Context> options = new DbContextOptionsBuilder<DBp0Context>()
                .UseSqlServer(configuration.GetConnectionString("ReferenceToDB"))
                .Options;

            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.StoreMenu:
                    return new StoreMenu(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
                case MenuType.InventoryMenu:
                   return new InventoryMenu(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))),
                            new InventoryBL(new RepositoryCloud(new DBp0Context(options))));
                case MenuType.AddStore:
                    return new AddStore(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
                case MenuType.ListStore:
                    return new ListStore(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
                case MenuType.QueryStore:
                    return new QueryStore(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
                case MenuType.QueryCustomer:
                    return new QueryCustomer(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
                case MenuType.CustomerSignUp:
                    return new AddCustomer(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
                case MenuType.GetAllCustomer:
                    return new ListCustomer(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
                case MenuType.AddProduct:
                    return new AddProduct(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
                //case MenuType.AddPurchaseOrder:
                   // return new AddPurchaseOrder(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
                
                
                //case MenuType.ListProduct:
                //    return new ListProduct(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
               // case MenuType.QueryProduct:
               //     return new QueryProduct(new StoreFrontBL(new RepositoryCloud(new DBp0Context(options))));
                default:
                    return null;
            }
        }
    }
}
