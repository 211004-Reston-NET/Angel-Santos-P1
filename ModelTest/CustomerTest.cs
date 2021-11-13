using StoreModels;
using Xunit;

namespace ModelTest 
{//CLI 'dotnet test' to run test cases
    public class CustomerTest
    {
        /// <summary>
        /// Will test if the city property will set with valid data 
          [Fact] // Fact is a testcase that doesn't have any parameters
          //Runs only once.
        public void IdSetValidData() 
        {
            //Arrange
            Customer _custTest = new Customer();
            int id = 1234;
            
                //Act
            _custTest.CustomerId = id;

                //Assert
            Assert.Equal(_custTest.CustomerId, id);
    
        }    

        [Fact]
        public void SetValidFirstName() 
        {
            Customer _custTest = new Customer();
            string fname = "Sam";

            _custTest.FirstName = fname;

            Assert.NotNull(_custTest.FirstName);
            Assert.Equal(_custTest.FirstName, fname);

        }

        [Fact]
        public void SetValidLastName() 
        {
            Customer _custTest = new Customer();
            string lname = "Wise";

            _custTest.LastName = lname;

            Assert.NotNull(_custTest.LastName);
            Assert.Equal(_custTest.LastName, lname);

        }

        [Fact]
        public void SetValidStreet() 
        {
            Customer _custTest = new Customer();
            string street = "123 Shire Road";

            _custTest.StreetAddress = street;

            Assert.NotNull(_custTest.StreetAddress);
            Assert.Equal(_custTest.StreetAddress, street);
        }

        [Fact]
        public void SetValidEmail() 
        {
            Customer _custTest = new Customer();
            string email = "samwise@meshire.net";

            _custTest.Email = email;

            Assert.NotNull(_custTest.Email);
            Assert.Equal(_custTest.Email, email);
        }

        [Fact]
        public void SetValidPhone() 
        {
            Customer _custTest = new Customer();
            int phone = 555123456;

            _custTest.Phone = phone;

            Assert.Equal(_custTest.Phone, phone);
        }
    }
}
        

