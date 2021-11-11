using System;
using StoreModels;
using Xunit;

namespace ModelTest 
{//CLI 'dotnet test' to run test cases
    public class ProductTest 
    {
        /// <summary>
        /// Will test if the city property will set with valid data 
          [Fact] // Fact is a testcase that doesn't have any parameters
          //Runs only once.
        public void ValidData() 
        {
            //Arrange
        Product _prodTest = new Product();
        decimal price = 57;
      
            //Act
        _prodTest.Price = price; 

            //Assert
        Assert.Equal(_prodTest.Price, price);
      
        }
        
        
    }
}

            