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
                Assert.Equal(3, test.Count);
                Assert.Equal("Angel's New Store", test[0].StoreName);

            }
        }

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
                            {
                                
                            }
                        )
                        
                    
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
        

                
                            
                
            
        
    