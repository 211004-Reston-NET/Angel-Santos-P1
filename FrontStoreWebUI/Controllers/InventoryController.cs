using System;
using FrontStoreWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using StoreBL;
using StoreModels;

namespace FrontStoreWebUI.Controllers
{
    public class InventoryController : Controller
    {
        private  IInventoryBL _invBL;
        private  IProductBL _prodBL;
        private  IStoreBL _storeBL;


        public InventoryController(IInventoryBL p_invBL, IProductBL p_prodBL, IStoreBL p_storeBL) 
        {
            _invBL = p_invBL;
            _prodBL = p_prodBL;
            _storeBL = p_storeBL;

        }

        
         public ActionResult Index(int p_id)
        {
            try
            {
            return View(_invBL.AllItemStoreInfo(p_id));
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return BadRequest("StoreCheck information not found.");
            }

        }
        
        [HttpGet]
        public ActionResult SelectProduct(int p_id)
        {
            try
            {
            Inventory _id = _invBL.GetItemById(p_id);
            return View(new StoreInvCheckVM(_id));
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return BadRequest("StoreCheck - Item ID selection not found.");
            }
        }

        [HttpPost]
        public IActionResult SelectProduct(StoreInvCheckVM item)
        {
            try
            {
            if (ModelState.IsValid)
            {
                Inventory invRep = _invBL.GetItemById(item.ProductId);
                invRep.Quantity =+ item.Quantity;
                _invBL.Replenish(invRep);
                return RedirectToAction(nameof(Index));
            }
            return View();
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return BadRequest("StoreCheck - item ID for inventory replenishment not found.");
            }
        }

    }
}
