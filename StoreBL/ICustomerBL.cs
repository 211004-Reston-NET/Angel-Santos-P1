using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface ICustomerBL
    {
        /// <summary>
        /// Add Customer to the database
        /// </summary>
        /// <param name="p_customer"></param>
        /// <returns></returns>
        Customer CustomerSignUp(Customer p_customer);
        
        /// <summary>
        /// Get a list of all customers in the database
        /// </summary>
        /// <returns></returns>
        List<Customer> GetAllCustomers();
        
        /// <summary>
        /// Get/Select a customer by ID
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        Customer GetCustomerById(int p_id);
        
        /// <summary>
        /// Search Customer by first name
        /// </summary>
        /// <param name="p_cust"></param>
        /// <returns></returns>
        List<Customer> GetCustomerByFirstName(string p_cust);
        
        /// <summary>
        /// Search Customer by last name
        /// </summary>
        /// <param name="p_cust"></param>
        /// <returns></returns>
        List<Customer> GetCustomerByLastName(string p_cust);
        
        /// <summary>
        /// Search customer by first and last name.
        /// </summary>
        /// <param name="p_cust"></param>
        /// <returns></returns>
        List<Customer> GetCustomerByNames(string p_cust);

        
    }
}