using FrontStoreWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using StoreBL;
using StoreModels;
using System;
using System.Linq;

namespace FrontStoreWebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerBL _custBL;
        public CustomerController(ICustomerBL p_custBL)
        {
            _custBL = p_custBL;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            try
            {
                return View(_custBL.GetAllCustomers()
                .Select(c => new CustomerVM(c))
                .ToList()
                );
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return BadRequest("Invalid list customers request.");
            }
        }

              
        [HttpPost]
        public IActionResult Create(CustomerVM custVM)
        {
            try
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
            catch (Exception e)
            {
                Log.Error(e.Message);
                return BadRequest("Unable to add new customer.");
            }
        }

        [HttpGet]
        public IActionResult Select(int p_id)
        {
            try
            {
                Customer _cust = _custBL.GetCustomerById(p_id);
                return View(new CustomerVM(_cust));
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return BadRequest("Unable to locate ID.");
            }

        }

        [HttpPost]
        public IActionResult Select(CustomerVM p_cust)
        {
            try
            {
                return View(_custBL.GetCustomerByFirstName(p_cust.FirstName)
               .Select(cust => new CustomerVM(cust))
               .ToList());
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return BadRequest("Unable to locate name.");
            }

        }

     
        public ActionResult Delete(int p_id)
        {
            try
            {
            //Passing the restaurant to the delete view
            return View(new CustomerVM(_custBL.GetCustomerById(p_id)));
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return BadRequest("Delete could not be processed.");
            }

        }        

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
