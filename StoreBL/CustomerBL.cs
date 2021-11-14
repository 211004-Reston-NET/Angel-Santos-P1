using System.Collections.Generic;
using System.Linq;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class CustomerBL:ICustomerBL
    {
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
        

        /*public IEnumerable<List<Customer>> GetCustomerByNames(GetCustomerByFirstName, GetCustomerByLastName)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomers();
           // List<Customer> listOfFirstName = _repo.GetCustomerByFirstName(p_cust);
           // List<Customer> listOfLastName = _repo.GetCustomerByLastName(p_cust); 
            return new List<Customer> {GetCustomerByFirstName, GetCustomerByLastName}; //(p_cust) + GetCustomerByLastName(p_cust1);
            //return _repo.GetCustomerByFirstName(p_cust), GetCustomerByLastName(p_cust1);


        }
        */
        /*public List<Customer> GetCustomerByNames(string p_cust, string p_cust1)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomers();
            return listOfCustomer.Where(cust => cust.FirstName.
                                                    ToLower().
                                                    Contains(p_cust.ToLower()) 
                                            && cust.LastName.
                                                    ToLower().
                                                    Contains(p_cust.ToLower())).
                                                    ToList();
                                //.Where(cust => cust.LastName.ToLower().Contains(p_cust1.ToLower())).ToList();
        }
        */
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
