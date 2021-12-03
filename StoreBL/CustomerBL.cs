using System.Collections.Generic;
using System.Linq;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class CustomerBL:ICustomerBL
    {
        /// <summary>
        /// Dependency injection
        /// </summary>
        private IRepository _repo;
        
        public CustomerBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Customer CustomerSignUp(Customer p_customer)
            {
            return _repo.AddCustomer(p_customer);
            }
        
        public Customer DeleteCustomer(Customer p_customer)
            {
            return _repo.DeleteCustomer(p_customer);
            }
        
        public List<Customer> GetAllCustomers()
        {
            
            return _repo.GetAllCustomers();
        
        }

        public List<Customer> GetCustomerByNames(string p_cust)
        {
            return _repo.GetCustomerByNames(p_cust);
        }
        

        public List<Customer> GetCustomerByFirstName(string p_cust)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomers();
            return listOfCustomer.Where(cust => cust.FirstName.ToLower().Contains(p_cust.ToLower())).ToList();
        }  

        public List<Customer> GetCustomerByLastName(string p_cust)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomers();
            return listOfCustomer.Where(cust => cust.LastName.ToLower().Contains(p_cust.ToLower())).ToList();
        }

        public Customer GetCustomerById(int p_id)
        {
            return _repo.GetCustomerById(p_id);
        }

    }
}
