using System;
using StoreModels;
using Xunit;

namespace ModelTest
{//CLI 'dotnet test' to run test cases
    public class StoreFrontTest
    {

        [Fact] // Fact is a testcase that doesn't have any parameters

        public void ValidStoreName()
        {
            //Arrange
            StoreFront _store = new StoreFront();
            string name = "TestStoreName";

            //Act
            _store.StoreName = name;

            //Assert
            Assert.Equal(_store.StoreName, name);

        }

        [Fact]
        public void ValidStoreAddress()
        {
            //Arrange
            StoreFront _store = new StoreFront();
            string addr = "1234 TestAddress Street Road Blvd.";

            //Act
            _store.Address = addr;

            //Assert
            Assert.Equal(_store.Address, addr);

        }

        [Fact]
        public void ValidStoreCity()
        {
            //Arrange
            StoreFront _store = new StoreFront();
            string city = "TestCity";

            //Act
            _store.City = city;

            //Assert
            Assert.Equal(_store.City, city);

        }

        [Fact]
        public void ValidStoreState()
        {
            //Arrange
            StoreFront _store = new StoreFront();
            string state = "NJNYMINZ";

            //Act
            _store.State = state;

            //Assert
            Assert.Equal(_store.State, state);

        }

        


    }
}

