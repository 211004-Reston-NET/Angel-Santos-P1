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
    public class PurchaseOrderController : Controller
    {
        private IOrderBL _orderBL;
        private IProductBL _prodBL;
        private IStoreBL _storeBL;
        public PurchaseOrderController(IOrderBL p_ordBL, IProductBL p_prodBL, IStoreBL p_storeBL)
        {
            _orderBL = p_ordBL;
            _prodBL = p_prodBL;
            _storeBL = p_storeBL;

        }
        // GET: PurchaseOrderController
        

        // GET: PurchaseOrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(_orderBL.ShowOrders()
                .Select(c => new PurchaseOrderVM(c))
                .ToList()
                );
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        
        public IActionResult Create(PurchaseOrderVM p_pur)
        {
            //This if statement will check if the current model that is being passed through is valid
            //If not, the asp-validation-for attribute elements will appear and autofill in the proper feedback for the user 
            //to correct themselves
            if (ModelState.IsValid)
            {
                _orderBL.PlaceOrder(new PurchaseOrder()
                {
                    TotalPrice = p_pur.TotalPrice,
                    ProductId = p_pur.ProductId,
                    StoreFrontId = p_pur.StoreFrontId,
                    PurchaseDate = p_pur.PurchaseDate,
                    CustomerId = p_pur.CustomerId
                    
                });

                return RedirectToAction(nameof(Index));
            }

            //Will return back to the create view if the user didn't specify the right input
            return View();
        }

        // POST: PurchaseOrderController/Purchase
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IFormCollection collection)
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

       

        public ActionResult Edit(int id)
        {
            return View();
        }

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

        public ActionResult Delete(int p_id)
        {
            
            return View(new PurchaseOrderVM(_orderBL.GetOrderById(p_id)));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int OrderId, IFormCollection collection)
        {
            try
            {
                PurchaseOrder _erase = _orderBL.GetOrderById(OrderId);
                _orderBL.DeleteOrder(_erase);
                return RedirectToAction(nameof(Index));
            }

            catch

            {
                return View();
            }
        
        }
        
    }
}
