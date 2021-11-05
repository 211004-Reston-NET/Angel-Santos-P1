
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

            }
        }

        /*[Fact]
        public void AddCustomer()
        {
            //You can use DBp0Context vs var instead.
            using (var context = new DBp0Context(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);

                //Act
                var test = repo.AddCustomer(context);


                //Assert
                Assert.Equal(2, test.Count);

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
                        StoreName = "Angel's Store",
                        Address = "12 Jersey Place",
                        City = "Jersey City",
                        State = "NJ"
                        //Product = new List<Product>

                    },
                    new StoreFront
                    {
                        StoreName = "Steve's Store",
                        Address = "2 Bergen Street",
                        City = "Newark",
                        State = "NJ"
                    }
                );
            }
        }
    }
}