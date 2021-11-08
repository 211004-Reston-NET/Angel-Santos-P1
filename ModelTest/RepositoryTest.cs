
using Microsoft.EntityFrameworkCore;
using StoreDL;
using StoreModels;
using Xunit;

namespace ModelTest
{
    public class RepositoryTest
    {
        private readonly DbContextOptions<DBp0Context> _options;
        public RepositoryTest()
        {
            _options = new DbContextOptionsBuilder<DBp0Context>()
                        .UseSqlite("Filename = Test.db").Options; //UseSqlite() method will create an in memory database for us - Test.db
        }
        [Fact]
        public void GetAllStore()
        {
            using (var context = new DBp0Context(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);

                //Act
                var test = repo.GetAllStore();

                //Assert
                Assert.Equal(2, test.Count);
                Assert.Equal("Angel's Store", test[0].StoreName);

            }
        }

        [Fact]
        public void AddStoreShouldAddStore()
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
                    State = "New Jersey"
                };

                //Act
                repo.AddStore(addedStore);

            }

            //using block will verify the store is added
            using (DBp0Context contexts = new DBp0Context(_options))
            {
                StoreFront result = contexts.StoreFronts.Find(3);

                Assert.NotNull(result);
                Assert.Equal("Angel's New Store", result.StoreName);
                Assert.Equal("1 Somewhere Rd.", result.Address);
                Assert.Equal("Horchata City", result.City);
                Assert.Equal("New Jersey", result.State);
            }
        }
    }
}

        /*
         * Return to Test 

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
                                StoreName = "Angel's Store",
                                Address = "12 Jersey Place",
                                City = "Jersey City",
                                State = "NJ",
                                Products = new List<Product>
                            
                            {
                                    new Product
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
                
            
        
    