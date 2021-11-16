using System;
using StoreModels;
using Xunit;

namespace ModelTest 
{//CLI 'dotnet test' to run test cases
    public class ProductTest 
    {
        
          [Fact] // Fact is a testcase that doesn't have any parameters
          
        public void ValidItemName() 
        {
            //Arrange
        Product _prodTest = new Product();
        string name = "TestItem";
      
            //Act
        _prodTest.ItemName = name; 

            //Assert
        Assert.Equal(_prodTest.ItemName, name);
      
        }

        [Fact]
        public void ValidCategory () 
        {
            //Arrange
        Product _prodTest = new Product();
        string cata = "Test Category";
      
            //Act
        _prodTest.Category = cata; 

            //Assert
        Assert.Equal(_prodTest.Category, cata);
      
        }

        [Fact]
        public void ValidPrice() 
        {
            //Arrange
        Product _prodTest = new Product();
        decimal price = 57;
      
            //Act
        _prodTest.Price = price; 

            //Assert
        Assert.Equal(_prodTest.Price, price);
      
        }

        [Fact]
        public void ValidDescription() 
        {
            //Arrange
        Product _prodTest = new Product();
        string descr = "Test test description";
      
            //Act
        _prodTest.Description = descr; 

            //Assert
        Assert.Equal(_prodTest.Description, descr);
      
        }
        
        
    }
}

            