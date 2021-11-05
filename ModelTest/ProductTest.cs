/*using System;
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
        public void NameSetValidData() 
        {
            //Arrange
        Product _prodTest = new Product();
        decimal price = 57;
      
            //Act
        _prodTest.Price = price; 

            //Assert
        Assert.NotNull(_prodTest.Price);
        Assert.Equal(_prodTest.Price, price);
      
        
        }
          

        [Theory]       
        [InlineData(678)] 
        [InlineData(9999)] 
        [InlineData(2389)]  
        [InlineData(299)]
        
        
        public void FailIfInvalid(decimal p_input)
        {//Arrange
            Product _prodTest = new Product();

            //Act & Assert
            //Throws method will only pass if the code you did will
            //give an Exception
            
            Assert.Throws<Exception>(() => _prodTest.Price = p_input); 
            // Because the Inline Data are strings - the result is Failed: 4; 
            // None of them returned an exception as the 'Act & Assert' method specified.
            // Their data was valid - so they are Valid Data
        }
    }
}

            */