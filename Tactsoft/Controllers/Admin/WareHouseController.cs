using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class WareHouseController : Controller
    {
        private readonly IWareHouseService _wareHouseService;
      

        public WareHouseController(IWareHouseService wareHouseService)
        {
            this._wareHouseService = wareHouseService;
        }
            
            
        // GET: WareHouseController
        public async Task<ActionResult> Index()
        {
            var warehouser = await _wareHouseService.GetAllAsync();
            return View(warehouser);
        }

        // GET: WareHouseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WareHouseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WareHouseController/Create
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

        // GET: WareHouseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WareHouseController/Edit/5
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

        // GET: WareHouseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WareHouseController/Delete/5
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
