using FrontStoreWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreBL;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return View(_invBL.AllItemStoreInfo(p_id));


        }
        /*
        [HttpGet]
        public IActionResult SelectProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SelectProduct(int p_id)
        {
            return View(_invBL.GetItemById(p_id));
           
        }
        */
        [HttpGet]
        public ActionResult SelectProduct(int p_id)
        {
            Inventory _id = _invBL.GetItemById(p_id);
            return View(new StoreInvCheckVM(_id));
        }

        [HttpPost]
        public IActionResult SelectProduct(StoreInvCheckVM item)
        {
            if (ModelState.IsValid)
            {
                Inventory invRep = _invBL.GetItemById(item.ProductId);

                invRep.Quantity = item.Quantity;

                _invBL.Replenish(invRep);

                return RedirectToAction(nameof(Index));

            }

            return View();
        }

        
            /*
            [HttpPost]
            public IActionResult Replenish(int p_id, int p_stockup)
            {
                if (ModelState.IsValid)
                { 
                    /

                 _invBL.ReplenishInventory(p_id, p_stockup);

                return View();

            }
            /*
            try
            {
                 Inventory update = _invBL.GetItemById(p_id);
                _invBL.ManualReplenish(update);
                return RedirectToAction(nameof(Index));
                //return View(_invBL.ManualReplenish(p_id));
            }
            catch
            {
                return View();
            }
            */
        }
}
