using FrontStoreWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using StoreBL;
using System;
using System.Linq;

namespace FrontStoreWebUI.Controllers
{
    public class StoreFrontController : Controller
    {
        //Field gets data from Business Layer
        private IStoreBL _storeBL;
        public StoreFrontController(IStoreBL p_storeBL){
            _storeBL = p_storeBL;
        }
        
        // GET: StoreFrontController
        public ActionResult Index(){
            try
            {
            return View(_storeBL.GetAllStore()
                .Select(store => new StoreVM(store))
                .ToList()
            );
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return BadRequest("All store information cannot be listed at this time.");
            }
        }

        public ActionResult StoreInv(int p_id)
        {
            try
            {
            return View(_storeBL.InventoryByStoreId(p_id)
                .Select(inv => new InventoryVM(inv)).ToList());
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return BadRequest("Store inventory information cannot be found");
            }
        }

        // GET: StoreFrontController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreFrontController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreFrontController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: StoreFrontController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreFrontController/Edit/5
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

        // GET: StoreFrontController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreFrontController/Delete/5
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
    }
}
