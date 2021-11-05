/*using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using StoreModels;

namespace StoreDL
{
    //The repository class has a bunch of methods that we will use to get or store information from the database
    //Does not actually hold the data itself
    // public System.Text.Json.Serialization.JsonNumberHandling NumberHandling { get; set; }
    public class Repository : IRepository
    {
        //Filepath need to reference from the startup project (StoreUI) and hence why we need to go back a folder and cd into StoreDL
        private const string _filepath = "./../StoreDL/Database/";
        private string _jsonString;

        public StoreFront AddStore(StoreFront p_store)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<StoreFront> listOfStores = GetAllStore();

            //We added the new store from the parameter 
            listOfStores.Add(p_store);

            _jsonString = JsonSerializer.Serialize(listOfStores, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the store.json
            File.WriteAllText(_filepath+"store.json",_jsonString);

            //Will return a store object from the parameter
            return p_store;
        }


        public List<StoreFront> GetAllStore()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"store.json");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<StoreFront>>(_jsonString);
        }

        public Customer CustomerSignUp(Customer p_customer)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Customer> listOfCustomer = GetAllCustomer();

            //We added the new customer from the parameter 
            listOfCustomer.Add(p_customer);

            _jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented=true});

            //This is what add the customer.json
            File.WriteAllText(_filepath+"customer.json",_jsonString);

            //Will return a store object from the parameter
            return p_customer;
        }


        public List<Customer> GetAllCustomer()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"customer.json");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);

        }
         public Product AddProduct(Product p_product)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Product> listOfProduct = GetAllProduct();

            //We added the new store from the parameter 
            listOfProduct.Add(p_product);

            _jsonString = JsonSerializer.Serialize(listOfProduct, new JsonSerializerOptions{WriteIndented=true, NumberHandling=JsonNumberHandling.AllowReadingFromString});
///var options = new JsonSerializerOptions { WriteIndented = true };
//            string jsonString = JsonSerializer.Serialize(weatherForecast, options);

            //This is what adds the store.json
            File.WriteAllText(_filepath+"store.json",_jsonString);

            //Will return a store object from the parameter
            return p_product;
        }
        public List<Product> GetAllProduct()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"product.json");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Product>>(_jsonString);

        }
        
    }
}
*/