using FrontStoreWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreBL;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontStoreWebUI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerBL _custBL;
        public CustomerController(ICustomerBL p_custBL)
        {
            _custBL = p_custBL;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            return View(_custBL.GetAllCustomers()
                .Select(c => new CustomerVM(c))
                .ToList()
                );
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        

        [HttpPost]
        public IActionResult Create(CustomerVM custVM)
        {
            //This if statement will check if the current model that is being passed through is valid
            //If not, the asp-validation-for attribute elements will appear and autofill in the proper feedback for the user 
            //to correct themselves
            if (ModelState.IsValid)
            {
                _custBL.CustomerSignUp(new Customer()
                {
                    FirstName = custVM.FirstName,
                    LastName = custVM.LastName,
                    StreetAddress = custVM.StreetAddress,
                    Email = custVM.Email,
                    Phone = custVM.Phone
                });

                return RedirectToAction(nameof(Index));
            }

            //Will return back to the create view if the user didn't specify the right input
            return View();
        }

        [HttpPost]
        public IActionResult Search(string p_cust)
        {

            return View(_custBL.GetCustomerByNames(p_cust)
                .Select(c => new CustomerVM(c))
                .ToList()
                );
            
        }
        


        // GET: CustomerController/Details/5
        public ActionResult Details()
        {
            return View();
        }


        public ActionResult Delete(int p_id)
        {
            //Passing the restaurant to the delete view
            return View(new CustomerVM(_custBL.GetCustomerById(p_id)));
        }



        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        /*
        public ActionResult Search(string p_cust)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: CustomerController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //     return View();
        // }

        // POST: CustomerController/Delete/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }
    }
}
