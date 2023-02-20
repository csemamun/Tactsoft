using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
   
    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            this._supplierService = supplierService;
        }
        // GET: SupliersController
        public async Task<ActionResult> Index()
        {
            var suppliers = await _supplierService.GetAllAsync();
            return View(suppliers);
        }

        // GET: SupliersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SupliersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupliersController/Create
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

        // GET: SupliersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SupliersController/Edit/5
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

        // GET: SupliersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupliersController/Delete/5
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
