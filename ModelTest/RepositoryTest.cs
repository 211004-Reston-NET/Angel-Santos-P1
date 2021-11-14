using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreDL;
using StoreModels;
using Xunit;

//Must add Store Ids
namespace ModelTest
{
    public class RepositoryTest
    {
        private readonly DbContextOptions<DBp0Context> _options;
        public RepositoryTest()
        {
            _options = new DbContextOptionsBuilder<DBp0Context>()
                        .UseSqlite("Filename = Test.db").Options; //UseSqlite() method will create an in memory database for us - Test.db
                        Seed();
        }

        [Fact]
        public void GetAllStoreTest()
        {
            using (var context = new DBp0Context(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);

                //Act
                var test = repo.GetAllStore();

                //Assert
                Assert.Equal(4, test.Count);
                Assert.Equal("Angel's New Store", test[0].StoreName);

            }
        }

        [Fact]
        public void ShowInventoryTest()
        {
            using (var context = new DBp0Context(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);

                //Act
                var test = repo.ShowInventory();

                //Assert
                Assert.Equal(3, test.Count);
                Assert.Equal(100, test[0].Quantity);

            }
        }

        [Fact]
        public void GetAllCustomersTest()
        {
            using (var context = new DBp0Context(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);

                //Act
                var test = repo.GetAllCustomers();

                //Assert
                Assert.Equal(3, test.Count);
                Assert.Equal("Billy", test[0].FirstName);

            }
        }

        [Fact]
        public void GetAllProductsTest()
        {
            using (var context = new DBp0Context(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);

                //Act
                var test = repo.GetAllProducts();

                //Assert
                Assert.Equal(3, test.Count);
                Assert.Equal(100, test[0].ProductId);

            }
        }

        [Fact]
        public void ShowOrdersTest()
        {
            using (var context = new DBp0Context(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);

                //Act
                var test = repo.ShowOrders();

                //Assert
                Assert.Equal(3, test.Count);
                Assert.Equal(101, test[0].OrderId);

            }
        }

        /*[Fact]
        public void ReplenishInventoryTest()
        {
            using (var context = new DBp0Context(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);

                //Act
                var test = repo.ReplenishInventory();

                //Assert
                Assert.Equal(3, test.Count);
                Assert.Equal(100, test[0].Quantity);

            }
        }
        */

        [Fact]
        public void AddStoreTest()
        {
            //You can use DBp0Context vs var instead.
            using (var context = new DBp0Context(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);
                StoreFront addedStore = new StoreFront
                {
                    
                    StoreName = "Angel's New Store",
                    Address = "1 Somewhere Rd.",
                    City = "Horchata City",
                    State = "NJ"
                };

                //Act
                repo.AddStore(addedStore);

            }

            //using block will verify the store is added
            using (DBp0Context contexts = new DBp0Context(_options))
            {
                StoreFront result = contexts.StoreFronts.Find(1);

                Assert.NotNull(result);
                Assert.Equal("Angel's New Store", result.StoreName);
                Assert.Equal("1 Somewhere Rd.", result.Address);
                Assert.Equal("Horchata City", result.City);
                Assert.Equal("NJ", result.State);
            }
        }

        

        //[Theory]
        //[InlineData("l")]
       /* public void GetCustomersByFName(string p_cust)
        {
            using (var context = new DBp0Context(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);
                
                //= context."l";

                //Act
                //List<Customer> listOfCustomer = repo.GetCustomerByFirstName("l");
                var test = repo.GetCustomerByFirstName(p_cust);

                //Assert.NotNull(() => _custTest.FirstName = p_cust);
                //Assert.Contains(p_cust);
                //Assert
                //Assert.Contains("l", test.Customer.FirstName);
               // Assert.Equal(1, listOfCustomer.Count);
                //Assert.Equal(2, test[0].CustomerId);
              //  Assert.Equal("l", test.FindAll);
               // Assert.Equal(101, test[0].FirstName);

            }
        }
        */
            
        private void Seed()
        {
            using (var context = new DBp0Context(_options))
                { 
                
                //Make sure inmemory DB gets deleted and recreates
                // To not show previous test.
                //'Create' pristine new DB for tests
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();

                    context.StoreFronts.AddRange
                    (
                        new StoreFront
                        {
                            StoreId = 1,
                            StoreName = "Angel's New Store",
                            Address = "1 Somewhere Rd.",
                            City = "Horchata City",
                            State = "NJ",   
                        },
                        new StoreFront
                        {
                            StoreId = 2,
                            StoreName = "Toy Store",
                            Address = "234 Road",
                            City = "That City",
                            State = "NY"
                        },
                        new StoreFront
                        {
                            StoreId = 3,
                            StoreName = "Fruit Store",
                            Address = "1 Street",
                            City = "NeoTokyo",
                            State = "NC"
                        },
                        new StoreFront
                        {
                            StoreId = 4,
                            StoreName = "Dollar Store",
                            Address = "2 Elsewhere Rd.",
                            City = "Black Mesa",
                            State = "UT",   
                        }
                        
                        
                    );
                    
                    context.Customers.AddRange
                    (
                        new Customer
                        {
                            CustomerId = 100,
                            FirstName = "Billy",
                            LastName = "TheKid",
                            StreetAddress = "123 West Avenue",
                            Email = "bilkid@gslingr.net",
                            Phone = 555234567

                        },
                        new Customer
                        {
                            CustomerId = 200,
                            FirstName = "Sal",
                            LastName = "Mon",
                            StreetAddress = "456 River Road",
                            Email = "sal@glorp.com",
                            Phone = 555765432

                        },
                        new Customer
                        {
                            CustomerId = 300,
                            FirstName = "Jim",
                            LastName = "Deane",
                            StreetAddress = "890 Creek Drive",
                            Email = "mtpapa@country.net",
                            Phone = 555098654

                        }
                        );
                        context.Products.AddRange
                        (
                            new Product
                            {
                                ProductId = 100,
                                ItemName = "DummyItem100",
                                Category = "CAT100",
                                Price = 100,
                                Description = "Product description - 100"

                            },
                            new Product
                            {
                                ProductId = 200,
                                ItemName = "DummyItem200",
                                Category = "CAT200",
                                Price = 200,
                                Description = "Product description - 200"

                            },
                            new Product
                            {
                                ProductId = 300,
                                ItemName = "DummyItem300",
                                Category = "CAT300",
                                Price = 300,
                                Description = "Product description - 300"

                            }
                        );
                        context.LineItems.AddRange
                        (
                            new LineItem
                            {
                                LineId = 101,
                                ProductId = 100,
                                Quantity = 1

                            },
                            new LineItem
                            {
                                LineId = 202,
                                ProductId = 200,
                                Quantity = 5

                            },
                            new LineItem
                            {
                                LineId = 303,
                                ProductId = 300,
                                Quantity = 10

                            }
                        );
                        context.PurchaseOrders.AddRange
                        (
                            new PurchaseOrder
                            {
                                OrderId = 101,
                                StoreFrontId = 1,
                                CustomerId = 100,
                                TotalPrice = 0
                        

                            },
                            new PurchaseOrder
                            {
                                OrderId = 102,
                                StoreFrontId = 2,
                                CustomerId = 200,
                                TotalPrice = 0

                            },
                            new PurchaseOrder
                            {
                                OrderId = 103,
                                StoreFrontId = 3,
                                CustomerId = 300,
                                TotalPrice = 0

                            }
                        );
                        context.Inventories.AddRange
                        (
                            new Inventory
                            {
                                InvId = 101,
                                StoreId = 1,
                                ProductId = 100,
                                Quantity = 100
                        
                            },
                            new Inventory
                            {
                                InvId = 102,
                                StoreId = 2,
                                ProductId = 200,
                                Quantity = 110

                            },
                            new Inventory
                            {
                                InvId = 103,
                                StoreId = 3,
                                ProductId = 300,
                                Quantity = 120

                            }
                        );
                        
                    context.SaveChanges();
                }
        }
    }
}


                                   /*new Product
                                    {
                                        ItemName = "VR-Machine",
                                        Category = "Game Console",
                                        Description = "Virtual reality",
                                        Price = 6
                                    },
                                    new Product
                                    {
                                        ItemName = "Discoball",
                                        Description = "Dancing lgihts",
                                        Category = "Party",
                                        Description = ""
                                    }
    
*/
        

                
                            
                
            
        
    