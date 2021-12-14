using FrontStoreWebUI.Models;
using Microsoft.AspNetCore.Mvc;
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
            return View(_invBL.AllItemStoreInfo(p_id));

        }
        
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

                invRep.Quantity =+ item.Quantity;

                _invBL.Replenish(invRep);

                return RedirectToAction(nameof(Index));

            }

            return View();
        }

    }
}
